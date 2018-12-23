using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace TravelPlannerApp
{
    public partial class info : Form
    {
        GMarkerGoogle marker;
        GMapOverlay markerOverlay;
        DataTable dt;
        int selection = 0;
        double Lat = 16.564165;
        double Lng = 107.161219;
        
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
                lblName.Image = TravelPlannerApp.Properties.Resources.Mộc_Châu1;
                Addmarker("Mộc Châu", 20.921494, 104.751506);

            }
            if (lblName.Text == "Mai Châu")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Mai_Châu;
                Addmarker("Mai Châu", 20.700946, 105.008195);
            }
            if (lblName.Text == "Tam Đảo")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Tam_Đảo;
                Addmarker("Tam Đảo", 21.453410, 105.644326);
            }

            if (lblName.Text == "Hàm Lợn")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Hàm_Lợn1;
                Addmarker("Hàm Lợn", 21.304661, 105.799158);
            }
            if (lblName.Text == "Mù Cang Chải")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Mù_Cang_Chải;
                Addmarker("Mù Cang Chải", 21.861005, 104.084881);
            }
            if (lblName.Text == "SaPa")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Sapa1;
                Addmarker("Sapa", 22.337147, 103.843957);
            }
            if (lblName.Text == "Háng Tề Chơ")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Háng_Tề_Chơ;
                Addmarker("Thác Háng Tề Chơ", 21.442122, 104.581266);
            }
            if (lblName.Text == "Hồ Pa Khoang")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.PaKhoang;
                Addmarker("Hồ Pa Khoang", 21.433561, 103.111535);
            }
            if (lblName.Text == "Vườn Quốc gia Xuân Sơn")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.VQGXS;
                Addmarker("Vườn Quốc Gia Xuân Sơn", 21.125919, 104.973535);
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
            if (lblName.Text == "Bến En")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Bến_En;
            }
            if (lblName.Text == "Biển Sầm Sơn")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Biển_Sầm_Sơn;
            }
            if (lblName.Text == "Cà Mau")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Cà_Mau;
            }
            if (lblName.Text == "Biển Thiên Cầm")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Biển_Thiên_Cầm;
            }
            if (lblName.Text == "Thung Nham - Thung Chim")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Thung_Nham___Thung_Chim;
            }
            if (lblName.Text == "Đèo Hải Vân – Đầm Lập An")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Đèo_Hải_Vân___Đầm_Lập_An;
            }
            if (lblName.Text == "Vườn Quốc Gia Bạch Mã")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Vườn_Quốc_Gia_Bạch_Mã;
            }
            if (lblName.Text == "Đèo A Co – Thác A Nor")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Đèo_A_Co___Thác_A_Nor;
            }
            if (lblName.Text == "Thành Phố Hồ Chí Minh")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Thành_Phố_Hồ_Chí_Minh;
            }
            if (lblName.Text == "Khe Tre - Thác Mơ")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Khe_Tre___Thác_Mơ;
            }
            if (lblName.Text == "Biển An Bàng")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Biển_An_Bàng;
            }
            if (lblName.Text == "Cù Lao Chàm")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Cù_Lao_Chàm;
            }
            if (lblName.Text == "Đà Lạt")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Đà_Lạt;
            }
            if (lblName.Text == "Nam Du")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Nam_Du;
            }
            if (lblName.Text == "Đường ven biển Ninh Thuận")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Đường_ven_biển_Ninh_Thuận;
            }
            if (lblName.Text == "Bảo Lộc - Đà Lạt – Dran")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Bảo_Lộc___Đà_Lạt___Dran;
            }
            if (lblName.Text == "Bình Ba")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Bình_Ba;
            }
            if (lblName.Text == "Bình Lập")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Bình_Lập;
            }
            if (lblName.Text == "Bình Hưng")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Bình_Hưng;
            }
            if (lblName.Text == "Đèo Pêke")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Đèo_Pêke;
            }
            if (lblName.Text == "Phú Quốc")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Phú_Quốc;
            }
            if (lblName.Text == "Vũng Tàu")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Vũng_Tàu;
            }
            if (lblName.Text == "Long An")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Long_An;
            }
            if (lblName.Text == "Tiền Giang")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Tiền_Giang;
            }
            if (lblName.Text == "Bến Tre")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Bến_Tre;
            }
            if (lblName.Text == "Trà Vinh")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Trà_Vinh;
            }
            if (lblName.Text == "Sóc Trăng")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Sóc_Trăng;
            }
            if (lblName.Text == "Cần Thơ")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Cần_Thơ;
            }
            if (lblName.Text == "Vĩnh Long")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Vĩnh_Long;
            }
            if (lblName.Text == "Đồng Tháp")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Đồng_Tháp;
            }
        }
        private void lblName_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {

        }
        public void Addmarker(string Name, double x, double y)
        {
            dt = GetTable(Name, x, y);
            //add marker position
            foreach (DataRow dr in dt.Rows)
            {
                markerOverlay = new GMapOverlay(System.Convert.ToString(dr["Name"]));
                marker = new GMarkerGoogle(new PointLatLng(System.Convert.ToDouble(dr["Lat"]), System.Convert.ToDouble(dr["Lng"])), GMarkerGoogleType.red_dot);
                markerOverlay.Markers.Add(marker);
                marker.ToolTipMode = MarkerTooltipMode.Always;
                //marker.ToolTipText = string.Format("{0}" + " Kinh độ: {1} " + " Vĩ độ: {2}", dr["Name"], dr["Lat"], dr["Lng"]);
                marker.ToolTipText = string.Format("{0}", dr["Name"]);
                gMapControl1.Overlays.Add(markerOverlay);
            }
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(Lat, Lng);
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 5;
            gMapControl1.AutoScroll = true;

        }
        public DataTable GetTable(string Name, double x, double y)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Lat", typeof(double));
            table.Columns.Add("Lng", typeof(double));

            table.Rows.Add(Name, x, y);
            table.Rows.Add("Yours places", 10.854309, 106.650977);
            return table;
        }
    }
}
