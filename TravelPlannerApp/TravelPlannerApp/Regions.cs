using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelPlannerApp
{
    public partial class Regions : Form
    {
        public Regions()
        {
            InitializeComponent();
        }

        private void btnbac_Click(object sender, EventArgs e)
        {
            NorthSide north = new NorthSide();
            north.ShowDialog();
        }

        private void btnnam_Click(object sender, EventArgs e)
        {
            SouthSide south = new SouthSide();
            south.ShowDialog();
        }
    }
}
