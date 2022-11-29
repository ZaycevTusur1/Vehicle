using Vehicle;

namespace VehicleView.Forms
{
    public partial class FindForm : Form
    {
        List<IVehicle> _vehicles = new List<IVehicle>();
        public FindForm(List<IVehicle> vehicles)
        {
            InitializeComponent();
            _vehicles.AddRange(vehicles);
            UpdateUi(_vehicles);
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            List<IVehicle> _findVehicles = new List<IVehicle>();
            if (!string.IsNullOrEmpty(NameTextBox.Text))
            {
                _findVehicles.AddRange(_vehicles.Where(p => p.Name == NameTextBox.Text));
            }

            if (!string.IsNullOrEmpty(FuelConsumptionMinTextBox.Text))
            {
                int fuelConsumption = int.Parse(FuelConsumptionMinTextBox.Text);

                if (_findVehicles.Count == 0)
                {
                    _findVehicles.AddRange(_vehicles.Where(p => p.CalculateFuel(100) > fuelConsumption));
                }
                else 
                {
                    _findVehicles = _findVehicles.Where(p => p.CalculateFuel(100) > fuelConsumption).ToList();
                }
            }
            if (!string.IsNullOrEmpty(FuelConsumptionMaxTextBox.Text))
            {
                int fuelConsumption = int.Parse(FuelConsumptionMaxTextBox.Text);
                if (_findVehicles.Count == 0)
                {
                    _findVehicles.AddRange(_vehicles.Where(p => p.CalculateFuel(100) < fuelConsumption));
                }
                else
                {
                    _findVehicles = _findVehicles.Where(p => p.CalculateFuel(100) < fuelConsumption).ToList();
                }
            }

            if (!string.IsNullOrEmpty(TankCopacityMaxTextBox.Text))
            {
                int copacity = int.Parse(TankCopacityMaxTextBox.Text);
                if (_findVehicles.Count == 0)
                {
                    _findVehicles.AddRange(_vehicles.Where(p => p.TankCapacity < copacity));
                }
                else
                {
                    _findVehicles = _findVehicles.Where(p => p.TankCapacity < copacity).ToList();
                }
            }
            if (!string.IsNullOrEmpty(TankCopacityMinTextBox.Text))
            {
                int copacity = int.Parse(TankCopacityMinTextBox.Text);
                if (_findVehicles.Count == 0)
                {
                    _findVehicles.AddRange(_vehicles.Where(p => p.TankCapacity > copacity));
                }
                else
                {
                    _findVehicles = _findVehicles.Where(p => p.TankCapacity > copacity).ToList();
                }
            }

            if (!string.IsNullOrEmpty(EngineCopacityMaxTextBox.Text))
            {
                int copacity = int.Parse(EngineCopacityMaxTextBox.Text);
                if(_findVehicles.Count == 0)
                {
                    _findVehicles.AddRange(_vehicles.Where(p => p.EngineCapacity < copacity));
                }
                else
                {
                    _findVehicles = _findVehicles.Where(p => p.EngineCapacity < copacity).ToList();
                }
            }
            if (!string.IsNullOrEmpty(EngineCopacityMinTextBox.Text))
            {
                int copacity = int.Parse(EngineCopacityMinTextBox.Text);
                if (_findVehicles.Count == 0)
                {
                    _findVehicles.AddRange(_vehicles.Where(p => p.EngineCapacity > copacity));
                }
                else
                {
                    _findVehicles = _findVehicles.Where(p => p.EngineCapacity > copacity).ToList();
                }
            }
            UpdateUi(_findVehicles);
        }
        public void UpdateUi(List<IVehicle> vehicles)
        {
            DataGridViewFindVehicle.RowCount = 0;
            int i = 1;
            foreach (var vehicle in vehicles)
            {
                DataGridViewFindVehicle.Rows.Add();
                DataGridViewFindVehicle[0, DataGridViewFindVehicle.RowCount - 1].Value = i;
                DataGridViewFindVehicle[1, DataGridViewFindVehicle.RowCount - 1].Value = vehicle.Name;
                DataGridViewFindVehicle[2, DataGridViewFindVehicle.RowCount - 1].Value = vehicle.EngineCapacity;
                DataGridViewFindVehicle[3, DataGridViewFindVehicle.RowCount - 1].Value = vehicle.TankCapacity;
                DataGridViewFindVehicle[4, DataGridViewFindVehicle.RowCount - 1].Value = vehicle.FuelConsumption;
                DataGridViewFindVehicle[4, DataGridViewFindVehicle.RowCount - 1].Value = vehicle.CalculateFuel(100);
                i++;
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            UpdateUi(_vehicles);
        }
    }
}
