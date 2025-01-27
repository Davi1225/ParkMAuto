using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ParkMAuto
{
    public partial class Simulation : Form
    {
        private Parking_List parkingListForm;

        // Constructor that accepts Parking_List instance
        public Simulation(Parking_List parkingList)
        {
            InitializeComponent();
            this.parkingListForm = parkingList;
        }

        // Default constructor for Simulation form
        public Simulation()
        {
            InitializeComponent();
        }

        // Constructor that accepts vehicle type and highlights relevant panels
        private string vehicleType;

        public Simulation(string vehicleType)
        {
            InitializeComponent();
            this.vehicleType = vehicleType;
            HighlightTablePanels();
        }

        // Event handler for Simulation form load
        private void Simulation_Load(object sender, EventArgs e)
        {
            tableLayoutPanel1.Tag = "2-Wheels";
            tableLayoutPanel2.Tag = "4-Wheels";
            tableLayoutPanel3.Tag = "2-Wheels";
            tableLayoutPanel4.Tag = "3-Wheels";
            tableLayoutPanel5.Tag = "3-Wheels";
        }

        // Method to highlight panels based on selected vehicle type
        private void HighlightTablePanels()
        {
            List<Panel> tablePanels = new List<Panel>
            {
                tableLayoutPanel1,
                tableLayoutPanel2,
                tableLayoutPanel3,
                tableLayoutPanel4,
                tableLayoutPanel5
            };

            // Determine the color to highlight based on the vehicle type
            Color highlightColor;
            switch (vehicleType)
            {
                case "4-Wheels":
                    highlightColor = Color.DarkKhaki;
                    break;
                case "3-Wheels":
                    highlightColor = Color.Peru;
                    break;
                case "2-Wheels":
                    highlightColor = Color.SandyBrown;
                    break;
                default:
                    highlightColor = SystemColors.Control;
                    break;
            }

            // Highlight the specific panels and set others to black
            foreach (Panel panel in tablePanels)
            {
                if (panel.Tag?.ToString() == vehicleType)
                {
                    panel.BackColor = highlightColor;
                }
                else
                {
                    panel.BackColor = Color.Black;
                }
            }
        }

        // Update button colors based on parking spot status
        public void UpdateButtonColors(List<string> statuses)
        {
            // Loop through the statuses list to update button colors
            for (int i = 0; i < statuses.Count; i++)
            {
                string status = statuses[i];

                // Construct the button name (e.g., btn1, btn2, etc.)
                string buttonName = $"btn{i + 1}";

                // Find the button control by its name
                Button button = this.Controls.Find(buttonName, true).FirstOrDefault() as Button;

                if (button != null)
                {
                    // Set the button color based on the status
                    button.BackColor = status.ToLower() switch
                    {
                        "available" => Color.Lime,
                        "park" => Color.Tomato,
                        "reserve" => Color.DarkTurquoise,
                        _ => SystemColors.Control // Default color for unknown statuses
                    };

/*                    // Optionally, you can also update the button text to display the status
                    button.Text = status;*/
                }
            }
        }



        private void btnback_Click(object sender, EventArgs e)
        {
            Parking_List parkingListForm = Application.OpenForms.OfType<Parking_List>().FirstOrDefault();

            if (parkingListForm != null)
            {
                parkingListForm.Show(); // Show the Parking_List form
                this.Hide(); // Hide the Simulation form
            
            }
        }


        private void btnhome_Click(object sender, EventArgs e)
        {
            // Retrieve the existing instance of Main from Application.OpenForms
            Main mainForm = Application.OpenForms.OfType<Main>().FirstOrDefault();

            if (mainForm == null)
            {
                // Create the Main form if it doesn't exist
                mainForm = new Main();
            }

            mainForm.Show(); // Show the Main form
            this.Hide(); // Hide the Simulation form
        }


        // Additional event handlers (for future functionality)
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btn31_Click(object sender, EventArgs e)
        {
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
