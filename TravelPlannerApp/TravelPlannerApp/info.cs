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
    public partial class info : Form
    {
        public delegate void SendMessage(string Message);
        public SendMessage Sender;
        public delegate void SendPicture(Image Picture);
        public SendPicture SenderP;
        public info()
        {
            InitializeComponent();
            Sender = new SendMessage(GetMessage);
            //SenderP = new SendPicture(GetPicture);

        }
        protected void info_Load(object sender, EventArgs e)
        {
            lblName.ForeColor = Color.Red;
        }
        private void GetMessage(string Message)
        {
            lblName.Text = Message;
            if (lblName.Text == "Mộc Châu")
            {
                
                lblName.Image = TravelPlannerApp.Properties.Resources.Mộc_Châu_400x255;
            }
            if(lblName.Text=="Mai Châu")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Mai_Châu;
            }
            if (lblName.Text == "Mai Châu")
            {

            }

            if (lblName.Text == "Mai Châu")
            {

            }
            if (lblName.Text == "Mai Châu")
            {

            }
            if (lblName.Text == "SaPa")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.SaPa;
            }
            if (lblName.Text == "Mai Châu")
            {

            }
            if (lblName.Text == "Mai Châu")
            {

            }
            if (lblName.Text == "Mai Châu")
            {

            }
            if (lblName.Text == "Mai Châu")
            {

            }
            if (lblName.Text == "Mai Châu")
            {

            }
            if (lblName.Text == "Mai Châu")
            {

            }
            if (lblName.Text == "Mai Châu")
            {

            }
            if (lblName.Text == "Mai Châu")
            {

            }
            if (lblName.Text == "Mai Châu")
            {

            }
            if (lblName.Text == "Mai Châu")
            {

            }
            if (lblName.Text == "Mai Châu")
            {

            }
            if (lblName.Text == "Mai Châu")
            {

            }
            if (lblName.Text == "Mai Châu")
            {

            }
            if (lblName.Text == "Mai Châu")
            {

            }
            if (lblName.Text == "Mai Châu")
            {

            }
            if (lblName.Text == "Mai Châu")
            {

            }
            if (lblName.Text == "Mai Châu")
            {

            }
            if (lblName.Text == "Mai Châu")
            {

            }
            if (lblName.Text == "Mai Châu")
            {

            }
            if (lblName.Text == "Mai Châu")
            {

            }
            if (lblName.Text == "Mai Châu")
            {

            }
            if (lblName.Text == "Mai Châu")
            {

            }
            if (lblName.Text == "Mai Châu")
            {

            }
            if (lblName.Text == "Mai Châu")
            {

            }
            if (lblName.Text == "Mai Châu")
            {

            }
            if (lblName.Text == "Mai Châu")
            {

            }
            if (lblName.Text == "Mai Châu")
            {

            }
            if (lblName.Text == "Mai Châu")
            {

            }
            if (lblName.Text == "Mai Châu")
            {

            }
            if (lblName.Text == "Mai Châu")
            {

            }
            if (lblName.Text == "Mai Châu")
            {

            }
            if (lblName.Text == "Mai Châu")
            {

            }
            if (lblName.Text == "Mai Châu")
            {

            }
            if (lblName.Text == "Mai Châu")
            {

            }
            if (lblName.Text == "Mai Châu")
            {

            }
            if (lblName.Text == "Mai Châu")
            {

            }
            if (lblName.Text == "Mai Châu")
            {

            }
            if (lblName.Text == "Mai Châu")
            {

            }
            if (lblName.Text == "Mai Châu")
            {

            }
            if (lblName.Text == "Mai Châu")
            {

            }
            if (lblName.Text == "Mai Châu")
            {

            }
            if (lblName.Text == "Mai Châu")
            {

            }

        }
       
    }
}
