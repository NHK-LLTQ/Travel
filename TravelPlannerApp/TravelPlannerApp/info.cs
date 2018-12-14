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
                lblName.Image = TravelPlannerApp.Properties.Resources.Mộc_Châu;
            }
            if(lblName.Text=="Mai Châu")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Mai_Châu;
            }
            if (lblName.Text == "Tam Đảo")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Tam_Đảo;
            }

            if (lblName.Text == "Hàm Lợn")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Hàm_Lợn;
            }
            if (lblName.Text == "Mù Cang Chải")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Mù_Cang_Chải;
            }
            if (lblName.Text == "SaPa")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.SaPa;
            }
            if (lblName.Text == "Háng Tề Chơ")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Háng_Tề_Chơ;
            }
            if (lblName.Text == "Hồ Pa Khoang")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Hồ_Pa_Khoang;
            }
            if (lblName.Text == "Vườn Quốc gia Xuân Sơn")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Vườn_Quốc_gia_Xuân_Sơn;
            }
            if (lblName.Text == "Đồng Cao")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Đồng_Cao;
            }
            if (lblName.Text == "Thác Bản Giốc")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Thác_Bản_Giốc;
            }
            if (lblName.Text == "Vườn quốc gia Ba Vì")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Vườn_quốc_gia_Ba_Vì;
            }
            if (lblName.Text == "Hồ Thung Nai")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Hồ_Thung_Nai;
            }
            if (lblName.Text == "Vịnh Lan Hạ")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Vịnh_Lan_Hạ;
            }
            if (lblName.Text == "Tây Yên Tử")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Tây_Yên_Tử;
            }
            if (lblName.Text == "Bãi Dài")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Bãi_Dài;
            }
            if (lblName.Text == "Bình Liêu")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Bình_Liêu;
            }
            if (lblName.Text == "Hồ Núi Cốc")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Hồ_Núi_Cốc;
            }
            if (lblName.Text == "Hồ Quan Sơn")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Hồ_Quan_Sơn;
            }
            if (lblName.Text == "Côn Sơn Kiếp Bạc")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Côn_Sơn_Kiếp_Bạc;
            }
            if (lblName.Text == "Đỉnh Lảo Thẩn")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Đỉnh_Lảo_Thẩn;
            }
            if (lblName.Text == "Tà Xùa")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Tà_Xùa;
            }
            if (lblName.Text == "Bạch Mộc Lương Tử")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Bạch_Mộc_Lương_Tử;
            }
            if (lblName.Text == "Núi Muối")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Núi_Muối;
            }
            if (lblName.Text == "Háng Đồng")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Háng_Đồng;
            }
            if (lblName.Text == "Y Tý")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Y_Tý;
            }
            if (lblName.Text == "Sìn Hồ")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Sìn_Hồ;
            }
            if (lblName.Text == "Pù Luông")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Pù_Luông;
            }
            if (lblName.Text == "Bà Nà")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Bà_Nà;
            }
            if (lblName.Text == "Đảo Lý Sơn")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Đảo_Lý_Sơn;
            }
            if (lblName.Text == "Cù Lao Xanh")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Cù_Lao_Xanh;
            }
            if (lblName.Text == "Biển Bình Tiên")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Biển_Bình_Tiên;
            }
            if (lblName.Text == "Đảo Phú Quý")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Đảo_Phú_Quý;
            }
            if (lblName.Text == "Động Thiên Đường")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Động_Thiên_Đường;
            }
            if (lblName.Text == "Vườn quốc gia Pù Mát")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Vườn_quốc_gia_Pù_Mát;
            }
            if (lblName.Text == "Suối Cá Thần Cẩm Lương")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Suối_Cá_Thần_Cẩm_Lương;
            }
            if (lblName.Text == "Vực Phun")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Vực_Phun;
            }
            if (lblName.Text == "Vịnh Vũng Rô")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Vịnh_Vũng_Rô;
            }
            if (lblName.Text == "")
            {

            }
            if (lblName.Text == "")
            {

            }
            if (lblName.Text == "")
            {

            }
            if (lblName.Text == "")
            {

            }
            if (lblName.Text == "")
            {

            }
            if (lblName.Text == "")
            {

            }
            if (lblName.Text == "")
            {

            }
            if (lblName.Text == "")
            {

            }
            if (lblName.Text == "")
            {

            }
            if (lblName.Text == "")
            {

            }

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }
    }
}
