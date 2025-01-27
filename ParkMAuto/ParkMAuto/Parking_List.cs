using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkMAuto
{
    public partial class Parking_List : Form
    {
        public Parking_List()
        {
            InitializeComponent();
            cmbstatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbvehicletype.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbparkingspot.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbvehicletype.SelectedIndexChanged += cmbvehicletype_SelectedIndexChanged;
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Enabled = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Main mainForm = new Main();
            mainForm.Show();

            this.Hide();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (cmbparkingspot.SelectedItem == null)
            {
                MessageBox.Show("Please select a parking spot!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string parkingSpot = cmbparkingspot.SelectedItem.ToString().Replace("#", "").Trim();
            string plateNumber = txtplatenum.Text.Trim();
            string carBrand = txtcarbrand.Text.Trim();
            string driverName = txtdrivername.Text.Trim();
            string status = cmbstatus.SelectedItem?.ToString();
            string vehicleType = cmbvehicletype.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(plateNumber) ||
                string.IsNullOrWhiteSpace(carBrand) ||
                string.IsNullOrWhiteSpace(driverName) ||
                string.IsNullOrWhiteSpace(status) ||
                string.IsNullOrWhiteSpace(vehicleType))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataGridViewRow targetRow = null;

            // Check for conflicts and find the target row
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                // Check if the entered parking spot exists
                if (row.Cells[0].Value?.ToString() == $"#{parkingSpot}")
                {
                    targetRow = row;

                    // Check if the spot is already occupied
                    if (row.Cells[1].Value?.ToString() != "Available")
                    {
                        MessageBox.Show("This parking spot is already occupied.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Check if the plate number exists in another spot
                if (row.Cells[2].Value?.ToString() == plateNumber && row.Cells[0].Value?.ToString() != $"#{parkingSpot}")
                {
                    MessageBox.Show("This plate number already exists in another parking spot.", "Duplicate Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // If the parking spot doesn't exist, create a new row
            if (targetRow == null)
            {
                targetRow = dataGridView1.Rows[dataGridView1.Rows.Add()];
            }

            // Save data to the target row
            targetRow.Cells[0].Value = $"#{parkingSpot}";
            targetRow.Cells[1].Value = status;
            targetRow.Cells[2].Value = plateNumber;
            targetRow.Cells[3].Value = carBrand;
            targetRow.Cells[4].Value = vehicleType;
            targetRow.Cells[5].Value = driverName;

            // Generate and assign a ticket if applicable
            if (status == "Park" || status == "Reserve")
            {
                targetRow.Cells[6].Value = GenerateRandomTicket();
            }

            MessageBox.Show("Information saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            UpdateSimulationForm(); // Update the Simulation form
            ClearInputs();
        }





        private DataGridViewRow selectedRowForEditing = null;

        private string GenerateRandomTicket()
        {
            Random random = new Random();
            int digits = random.Next(1000, 10000);
            string letters = new string(Enumerable.Range(0, 3)
                .Select(_ => (char)random.Next(65, 91))
                .Concat(Enumerable.Range(0, 3)
                .Select(_ => (char)random.Next(97, 123)))
                .OrderBy(_ => random.Next())
                .Take(3)
                .ToArray());

            return $"{digits}{letters}";
        }

        private void Parking_List_Load(object sender, EventArgs e)
        {
            InitializeDataGridView();

            cmbstatus.Items.Clear();
            cmbstatus.Items.Add("Park");
            cmbstatus.Items.Add("Reserve");
            LoadDataFromParkingData(ParkingData.ParkingRows);

            LoadData();
        }

        public void LoadDataFromParkingData(List<DataGridViewRow> parkingRows)
        {
            // Clear existing rows and reload from ParkingData
            dataGridView1.Rows.Clear();

            foreach (var row in parkingRows)
            {
                dataGridView1.Rows.Add(row);
            }
        }

        private void LoadData()
        {
            // Clear existing rows
            dataGridView1.Rows.Clear();

            // Add all 50 rows
            for (int i = 1; i <= 50; i++)
            {
                // Check if this parking spot exists in ParkingData
                var existingRow = ParkingData.ParkingRows.FirstOrDefault(row =>
                    row.Cells[0].Value?.ToString() == $"#{i}");

                if (existingRow != null)
                {
                    // Clone the row and add it to DataGridView
                    DataGridViewRow newRow = (DataGridViewRow)existingRow.Clone();
                    for (int j = 0; j < existingRow.Cells.Count; j++)
                    {
                        newRow.Cells[j].Value = existingRow.Cells[j].Value;
                    }
                    dataGridView1.Rows.Add(newRow);
                }
                else
                {
                    // Add a default "Available" row for missing spots
                    dataGridView1.Rows.Add($"#{i}", "Available", "", "", "", "", "");
                }
            }
        }

        public void RefreshDataGridView()
        {
            // Clear the DataGridView and reload data if needed
            dataGridView1.Rows.Clear();
            LoadData(); // Reload your data here
        }

        private void InitializeDataGridView()
        {


            dataGridView1.Rows.Clear();

            for (int i = 1; i <= 50; i++)
            {
                dataGridView1.Rows.Add($"#{i}", "Available", "", "", "", "", "");
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtsearch.Text.Trim().ToLower();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                bool matchFound = false;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().ToLower().Contains(searchText))
                    {
                        matchFound = true;
                        break;
                    }
                }
                row.Visible = matchFound;
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void ClearInputs()
        {
            txtcarbrand.Clear();
            txtdrivername.Clear();
            txtplatenum.Clear();

            cmbstatus.SelectedIndex = -1;
            cmbvehicletype.SelectedIndex = -1;
            cmbparkingspot.SelectedIndex = -1;
            cmbparkingspot.Items.Clear();
        }

        private void btnenter_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Check if the row is empty
                bool isEmptyRow = string.IsNullOrWhiteSpace(selectedRow.Cells[0].Value?.ToString()) &&
                                  string.IsNullOrWhiteSpace(selectedRow.Cells[1].Value?.ToString()) &&
                                  string.IsNullOrWhiteSpace(selectedRow.Cells[2].Value?.ToString()) &&
                                  string.IsNullOrWhiteSpace(selectedRow.Cells[3].Value?.ToString()) &&
                                  string.IsNullOrWhiteSpace(selectedRow.Cells[4].Value?.ToString()) &&
                                  string.IsNullOrWhiteSpace(selectedRow.Cells[5].Value?.ToString());

                if (isEmptyRow)
                {
                    MessageBox.Show("The selected row is empty. You can add new data.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearInputs();
                    return;
                }

                // Load data from the row into input fields
                cmbstatus.SelectedItem = selectedRow.Cells[1].Value?.ToString() ?? "";
                cmbparkingspot.SelectedItem = selectedRow.Cells[0].Value?.ToString() ?? "";
                txtplatenum.Text = selectedRow.Cells[2].Value?.ToString() ?? "";
                txtcarbrand.Text = selectedRow.Cells[3].Value?.ToString() ?? "";
                cmbvehicletype.SelectedItem = selectedRow.Cells[4].Value?.ToString() ?? "";
                txtdrivername.Text = selectedRow.Cells[5].Value?.ToString() ?? "";

                MessageBox.Show("Information loaded. You can now edit and save.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select a row to edit or add data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnout_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                selectedRow.Cells[1].Value = "Available";
                selectedRow.Cells[2].Value = "";
                selectedRow.Cells[3].Value = "";
                selectedRow.Cells[4].Value = "";
                selectedRow.Cells[5].Value = "";
                selectedRow.Cells[6].Value = "";

                UpdateSimulationForm();

                MessageBox.Show("Parking spot has been reset to available.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select a row to reset.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private Simulation simulationForm;



        private void btnSimulate_Click(object sender, EventArgs e)
        {
            // Extract statuses from the DataGridView
            List<string> statuses = new List<string>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;
                statuses.Add(row.Cells[1].Value?.ToString() ?? "Available"); // Default to "Available" if no status
            }

            // Create or show the Simulation form
            Simulation simulationForm = new Simulation();
            simulationForm.UpdateButtonColors(statuses); // Pass statuses to the Simulation form

            this.Hide(); // Hide the Parking_List form (not visible but still in memory)
            simulationForm.Show(); // Show the Simulation form
        }




        private void UpdateSimulationForm()
        {
            List<string> statuses = new List<string>();

            // Collect all statuses from the DataGridView
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;
                string status = row.Cells[1].Value?.ToString();
                statuses.Add(status);
            }

            // Pass the list of statuses to the Simulation form
            if (simulationForm != null && simulationForm.Visible)
            {
                simulationForm.UpdateButtonColors(statuses);
            }
        }


        private void PopulateParkingSpotOptions()
        {
            // Clear existing items
            cmbparkingspot.Items.Clear();

            string selectedVehicleType = cmbvehicletype.SelectedItem?.ToString();

            // Initialize the list of parking spots
            List<string> availableSpots = new List<string>();

            // Determine the parking spots based on the vehicle type
            if (selectedVehicleType == "4 Wheels")
            {
                // Show parking spots #31 to #50 for 4-wheel vehicles
                for (int i = 31; i <= 50; i++)
                {
                    availableSpots.Add($"#{i}");
                }
            }
            else if (selectedVehicleType == "2 Wheels")
            {
                // Show parking spots #1 to #10 and #16 to #25 for 2-wheel vehicles
                for (int i = 1; i <= 10; i++)
                {
                    availableSpots.Add($"#{i}");
                }
                for (int i = 16; i <= 25; i++)
                {
                    availableSpots.Add($"#{i}");
                }
            }
            else if (selectedVehicleType == "3 Wheels")
            {
                // Show parking spots #11 to #15 and #26 to #30 for 3-wheel vehicles
                for (int i = 11; i <= 15; i++)
                {
                    availableSpots.Add($"#{i}");
                }
                for (int i = 26; i <= 30; i++)
                {
                    availableSpots.Add($"#{i}");
                }
            }

            // Now, we need to filter out any spots that are already occupied
            List<string> occupiedSpots = dataGridView1.Rows
                .Cast<DataGridViewRow>()
                .Where(row => row.Cells[1].Value?.ToString() != "Available")
                .Select(row => row.Cells[0].Value?.ToString().Replace("#", "").Trim())
                .ToList();

            // Remove occupied spots from the available spots list
            availableSpots = availableSpots.Where(spot => !occupiedSpots.Contains(spot.Replace("#", "").Trim())).ToList();

            // Add available spots to cmbparkingspot
            cmbparkingspot.Items.AddRange(availableSpots.ToArray());

            // If there are no available spots left, show a message
/*            if (availableSpots.Count == 0)
            {
                MessageBox.Show("No available parking spots for the selected vehicle type.", "No Available Spots", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }*/
        }




        private void cmbstatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void cmbparkingspot_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbvehicletype_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateParkingSpotOptions();
        }
    }
}
