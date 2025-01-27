using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkMAuto
{
    public static class ParkingData
    {
        public static List<string> Statuses { get; set; } = new List<string>();

        // This will hold the rows of the DataGridView
        public static List<DataGridViewRow> ParkingRows { get; set; } = new List<DataGridViewRow>();
    }


}
