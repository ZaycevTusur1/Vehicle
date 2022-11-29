using Newtonsoft.Json;
using Vehicle;
using VehicleView.Forms;

namespace VehicleView
{
    public partial class Form1 : Form
    {
        public List<IVehicle> _vehicles = new List<IVehicle>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var form = new AddForm(this);
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            try
            {
                var form = new FindForm(_vehicles);
                form.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            string json = System.Text.Json.JsonSerializer.Serialize(_vehicles);
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog.FileName;
            System.IO.File.WriteAllText(filename, json);
        }
        private void OpenButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog.FileName;
            string fileText = File.ReadAllText(filename);
            try
            {
                var v = JsonConvert.DeserializeObject<List<Car>>(fileText);
                foreach (var emp in v)
                {
                    _vehicles.Add(emp);
                }
                UpdateUi();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            var deleteItem = DataGridViewVehicle.CurrentCell;
            if (deleteItem != null)
                _vehicles.RemoveAt(deleteItem.RowIndex);
            else
                MessageBox.Show("Choose employee");
            UpdateUi();
        }
        public void UpdateUi()
        {
            DataGridViewVehicle.RowCount = 0;
            int i = 1;
            foreach (var vehicle in _vehicles)
            {
                DataGridViewVehicle.Rows.Add();
                DataGridViewVehicle[0, DataGridViewVehicle.RowCount - 1].Value = i;
                DataGridViewVehicle[1, DataGridViewVehicle.RowCount - 1].Value = vehicle.Name;
                DataGridViewVehicle[2, DataGridViewVehicle.RowCount - 1].Value = vehicle.EngineCapacity;
                DataGridViewVehicle[3, DataGridViewVehicle.RowCount - 1].Value = vehicle.TankCapacity;
                DataGridViewVehicle[4, DataGridViewVehicle.RowCount - 1].Value = vehicle.FuelConsumption;
                DataGridViewVehicle[4, DataGridViewVehicle.RowCount - 1].Value = vehicle.CalculateFuel(100);
                i++;
            }
        }
    }
}