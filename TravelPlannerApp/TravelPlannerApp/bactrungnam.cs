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
    public partial class bactrungnam : Form
    {
        public bactrungnam()
        {
            InitializeComponent();
        }

        private void btnbac_Click(object sender, EventArgs e)
        {
            MienBac mb = new MienBac();
            mb.ShowDialog();
        }

        private void btntrung_Click(object sender, EventArgs e)
        {
            Travel trv = new Travel();
            trv.ShowDialog();
        }

        private void btnnam_Click(object sender, EventArgs e)
        {
            MienNam mn = new MienNam();
            mn.ShowDialog();
        }

        private void bactrungnam_Load(object sender, EventArgs e)
        {

        }
    }
}
