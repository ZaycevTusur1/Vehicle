using Vehicle;

namespace VehicleView.Forms
{
    public partial class AddForm : Form
    {
        private Form1 _mainForm;
        private IVehicle _vehicle;
        private bool _autoGen;
        private readonly Random _random = new Random();
        public AddForm(Form1 mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
            _autoGen = false;
            NameTexBox.Enabled = false;
            FuelConsumptionTextBox.Enabled = false;
            EngineCapacityTExtBox.Enabled = false;
            TankCapacityTextBox.Enabled = false;
            BatteryCopacityLabel.Visible = false;
            BatteryCopacityTextBox.Visible = false;
            PowerHeliTextBox.Visible = false;
            PowerHeliLabel.Visible = false;
#if !DEBUG
            GenereteButton.Visible = false;
#endif
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GenereteButton_Click(object sender, EventArgs e)
        {
            NameTexBox.Text = RandomString(10);
            FuelConsumptionTextBox.Text = _random.Next(1, 20).ToString();
            EngineCapacityTExtBox.Text = _random.Next(1, 6).ToString();
            TankCapacityTextBox.Text = _random.Next(50, 100).ToString();
            VehicleType.SelectedIndex = _random.Next(0, 2);
            IVehicle vehicle = null;
            if (VehicleType.SelectedIndex == 0)
            {
                NameTexBox.Enabled = true;
                FuelConsumptionTextBox.Enabled = true;
                EngineCapacityTExtBox.Enabled = true;
                TankCapacityTextBox.Enabled = true;
                BatteryCopacityLabel.Visible = false;
                BatteryCopacityTextBox.Visible = false;
                PowerHeliTextBox.Visible = false;
                PowerHeliLabel.Visible = false;
                vehicle = new Car
                {
                    Name = NameTexBox.Text,
                    EngineCapacity = int.Parse(EngineCapacityTExtBox.Text),
                    FuelConsumption = int.Parse(FuelConsumptionTextBox.Text),
                    TankCapacity = int.Parse(TankCapacityTextBox.Text)
                };

            }
            else if (VehicleType.SelectedIndex == 1)
            {
                BatteryCopacityLabel.Visible = true;
                BatteryCopacityTextBox.Visible = true;
                BatteryCopacityTextBox.Text = _random.Next(0, 100).ToString();
                PowerHeliTextBox.Visible = false;
                PowerHeliLabel.Visible = false;
                vehicle = new HybridCar
                {
                    Name = NameTexBox.Text,
                    EngineCapacity = int.Parse(EngineCapacityTExtBox.Text),
                    FuelConsumption = int.Parse(FuelConsumptionTextBox.Text),
                    TankCapacity = int.Parse(TankCapacityTextBox.Text),
                    BatteryCopacity = int.Parse(BatteryCopacityTextBox.Text)
                };
            }
            else if (VehicleType.SelectedIndex == 2)
            {
                PowerHeliTextBox.Visible = true;
                PowerHeliTextBox.Text = _random.Next(100, 400).ToString();
                PowerHeliLabel.Visible = true;
                BatteryCopacityLabel.Visible = false;
                BatteryCopacityTextBox.Visible = false;
                vehicle = new Helicopter
                {
                    Name = NameTexBox.Text,
                    EngineCapacity = int.Parse(EngineCapacityTExtBox.Text),
                    FuelConsumption = int.Parse(FuelConsumptionTextBox.Text),
                    TankCapacity = int.Parse(TankCapacityTextBox.Text),
                    PowerHeli = int.Parse(PowerHeliTextBox.Text)
                };
            }
            if (vehicle is null)
                MessageBox.Show("Error in create employee");
            _autoGen = true;
            _vehicle = vehicle;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (_autoGen)
            {
                _mainForm._vehicles.Add(_vehicle);
                _mainForm.UpdateUi();
                _autoGen = false;
            }
            else
            {
                IVehicle vehicle;
                if (VehicleType.SelectedIndex == 0)
                {
                    if (!(string.IsNullOrEmpty(EngineCapacityTExtBox.Text) || string.IsNullOrEmpty(FuelConsumptionTextBox.Text) || string.IsNullOrEmpty(TankCapacityTextBox.Text)))
                    {
                        int eng, fcop, tank;
                        if (int.TryParse(EngineCapacityTExtBox.Text, out eng) && int.TryParse(FuelConsumptionTextBox.Text, out fcop)
                            && int.TryParse(TankCapacityTextBox.Text, out tank))
                        {
                            if(eng > 0 && fcop > 0 && tank > 0)
                            {
                                vehicle = new Car
                                {
                                    Name = NameTexBox.Text,
                                    EngineCapacity = eng,
                                    FuelConsumption = fcop,
                                    TankCapacity = tank
                                };
                                _mainForm._vehicles.Add(vehicle);
                            }
                            else
                            {
                                MessageBox.Show("Параметры должны быть больше нуля");
                            }
                            
                        }
                        else
                        {
                            MessageBox.Show("Параметры должны быть целочисленные");
                        }
                    }

                }
                else if (VehicleType.SelectedIndex == 1)
                {
                    if (!(string.IsNullOrEmpty(EngineCapacityTExtBox.Text) || string.IsNullOrEmpty(FuelConsumptionTextBox.Text) || string.IsNullOrEmpty(TankCapacityTextBox.Text) || string.IsNullOrEmpty(BatteryCopacityTextBox.Text)))
                    {
                        int eng, fcop, tank, pow;
                        if (int.TryParse(EngineCapacityTExtBox.Text, out eng) && int.TryParse(FuelConsumptionTextBox.Text, out fcop)
                            && int.TryParse(TankCapacityTextBox.Text, out tank) && int.TryParse(BatteryCopacityTextBox.Text, out pow))
                        {
                            if (eng > 0 && fcop > 0 && tank > 0 && pow > 0)
                            {
                                vehicle = new HybridCar
                                {
                                    Name = NameTexBox.Text,
                                    EngineCapacity = eng,
                                    FuelConsumption = fcop,
                                    TankCapacity = tank,
                                    BatteryCopacity = pow
                                };
                                _mainForm._vehicles.Add(vehicle);
                            }
                            else
                            {
                                MessageBox.Show("Параметры должны быть больше нуля");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Параметры должны быть целочисленные");
                        }                        
                    }

                }
                else if (VehicleType.SelectedIndex == 2)
                {
                    if (!(string.IsNullOrEmpty(EngineCapacityTExtBox.Text) || string.IsNullOrEmpty(FuelConsumptionTextBox.Text) || string.IsNullOrEmpty(TankCapacityTextBox.Text) || string.IsNullOrEmpty(PowerHeliTextBox.Text)))
                    {
                        int eng, fcop, tank, pow;
                        if (int.TryParse(EngineCapacityTExtBox.Text, out eng) && int.TryParse(FuelConsumptionTextBox.Text, out fcop)
                            && int.TryParse(TankCapacityTextBox.Text, out tank) && int.TryParse(PowerHeliTextBox.Text, out pow))
                        {
                            if (eng > 0 && fcop > 0 && tank > 0 && pow > 0)
                            {
                                vehicle = new Helicopter
                                {
                                    Name = NameTexBox.Text,
                                    EngineCapacity = eng,
                                    FuelConsumption = fcop,
                                    TankCapacity = tank,
                                    PowerHeli = pow
                                };
                                _mainForm._vehicles.Add(vehicle);
                            }
                            else
                            {
                                MessageBox.Show("Параметры должны быть больше нуля");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Параметры должны быть целочисленные");
                        }                    
                    }

                }

                _mainForm.UpdateUi();
            }
        }

        private void VehicleType_SelectedIndexChanged(object sender, EventArgs e)
        {
            NameTexBox.Enabled = true;
            FuelConsumptionTextBox.Enabled = true;
            EngineCapacityTExtBox.Enabled = true;
            TankCapacityTextBox.Enabled = true;
            if (VehicleType.SelectedIndex == 0)
            {

                BatteryCopacityLabel.Visible = false;
                BatteryCopacityTextBox.Visible = false;
                PowerHeliTextBox.Visible = false;
                PowerHeliLabel.Visible = false;
            }
            else if (VehicleType.SelectedIndex == 1)
            {

                BatteryCopacityLabel.Visible = true;
                BatteryCopacityTextBox.Visible = true;
                PowerHeliTextBox.Visible = false;
                PowerHeliLabel.Visible = false;
            }
            else if (VehicleType.SelectedIndex == 2)
            {
                PowerHeliTextBox.Visible = true;
                PowerHeliLabel.Visible = true;
                BatteryCopacityLabel.Visible = false;
                BatteryCopacityTextBox.Visible = false;
            }
        }


        private string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[_random.Next(s.Length)]).ToArray());
        }

        private void AddForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FuelConsumptionLabel_Click(object sender, EventArgs e)
        {

        }

        private void TankCapacityLabel_Click(object sender, EventArgs e)
        {

        }

        private void PowerHeliLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
