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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnsignout_Click(object sender, EventArgs e)
        {
            Form1 mainForm = new Form1();
            mainForm.Show();

            this.Hide();
        }

        private void btnlist_Click(object sender, EventArgs e)
        {
            // Check if Parking_List is already open
            Parking_List parkingListForm = Application.OpenForms.OfType<Parking_List>().FirstOrDefault();

            if (parkingListForm == null)
            {
                // Create a new instance of Parking_List if it's not already open
                parkingListForm = new Parking_List();

                // Pass current data from ParkingData to Parking_List
                parkingListForm.LoadDataFromParkingData(ParkingData.ParkingRows);
            }

            parkingListForm.Show(); // Show the Parking_List form
            this.Hide(); // Hide the Main form
        }


        private void btnsimulation_Click(object sender, EventArgs e)
        {
            // Retrieve the existing instance of Simulation from Application.OpenForms
            Simulation simulationForm = Application.OpenForms.OfType<Simulation>().FirstOrDefault();

            if (simulationForm == null)
            {
                // Create the Simulation form if it doesn't exist
                simulationForm = new Simulation();
            }

            simulationForm.Show(); // Show the Simulation form
            this.Hide(); // Hide the Main form
        }


        private void button1_Click(object sender, EventArgs e)
        {
            OpenSimulationForm("4-Wheels");
        }

        private void btn2wheels_Click(object sender, EventArgs e)
        {
            OpenSimulationForm("2-Wheels");
        }

        private void btn3wheels_Click(object sender, EventArgs e)
        {
            OpenSimulationForm("3-Wheels");
        }
        private void OpenSimulationForm(string vehicleType)
        {
            Simulation simulationForm = new Simulation(vehicleType);
            simulationForm.Show();
            this.Hide(); // Optionally hide the homepage
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Help mainForm = new Help();
            mainForm.Show();

            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            About mainForm = new About();
            mainForm.Show();

            this.Hide();
        }
    }
}
