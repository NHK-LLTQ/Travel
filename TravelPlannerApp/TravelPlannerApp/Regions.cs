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

        private void Regions_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
        }

        private void Regions_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Regions_FormClosed(object sender, FormClosedEventArgs e)
        {
            for (int i = 0; i < 1; i++)
            {
                if (MessageBox.Show("Do you want to quit?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else return;
            }
        }
    }
}
