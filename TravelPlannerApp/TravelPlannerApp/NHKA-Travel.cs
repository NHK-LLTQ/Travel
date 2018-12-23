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
    public partial class NHKA_Travel : Form
    {
        public NHKA_Travel()
        {
            InitializeComponent();
        }

        private void NHKA_Travel_Load(object sender, EventArgs e)
        {
            //label1.Dock = DockStyle.Fill;
        }

        private void NHKA_Travel_MouseClick(object sender, MouseEventArgs e)
        {
            Regions Regi = new Regions();
            Regi.ShowDialog();
            this.Hide();
        }
    }
}
