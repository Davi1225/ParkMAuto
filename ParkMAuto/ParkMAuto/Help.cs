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
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void btnsignout_Click(object sender, EventArgs e)
        {
            Main mainForm = new Main();
            mainForm.Show();

            this.Hide();
        }
    }
}
