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
       
        List<PointLatLng> _points;
        GMarkerGoogle marker;
        GMapOverlay markerOverlay;
        DataTable dt;
        
        double Lat = 16.564165;
        double Lng = 107.161219;
        
        public delegate void SendMessage(string Message);
        public SendMessage Sender;
        public info()
        {
            InitializeComponent();
            Sender = new SendMessage(GetMessage);
            _points = new List<PointLatLng>();
            //SenderP = new SendPicture(GetPicture);
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;



        }
        protected void info_Load(object sender, EventArgs e)
        {
            lblName.ForeColor = Color.Red;
            gMapControl1.ShowCenter = false;
            GMapProviders.BingMap.ClientKey = @"ArvE9po73RFIArjZRtFAexLAQdwbKTRKZVgvmeLhu0-LfKxmGpNZbUce0JY52G2U ";



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
                Addmarker("Đồng Cao", 21.410072, 106.881258);
            }
            if (lblName.Text == "Thác Bản Giốc")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Thác_Bản_Giốc;
                Addmarker("Thác Bản Giốc", 22.855312, 106.722592);
            }
            if (lblName.Text == "Vườn quốc gia Ba Vì")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Vườn_quốc_gia_Ba_Vì;
                Addmarker("Vườn quốc gia Ba Vì", 21.082548, 105.369810);
            }
            if (lblName.Text == "Hồ Thung Nai")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Hồ_Thung_Nai;
                Addmarker("Hồ Thung Nai", 20.745814, 105.225331);
            }
            if (lblName.Text == "Vịnh Lan Hạ")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Vịnh_Lan_Hạ;
                Addmarker("Vịnh Lan Hạ", 20.723874, 107.046046);
            }
            if (lblName.Text == "Tây Yên Tử")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Tây_Yên_Tử;
                Addmarker("Tây Yên Tử", 21.182313, 106.722310);
            }
            if (lblName.Text == "Bãi Dài")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Bãi_Dài;
                Addmarker("Bãi Dài", 21.130122, 106.533865);
            }
            if (lblName.Text == "Bình Liêu")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Bình_Liêu;
                Addmarker("Bình Liêu",21.540689, 107.432711);
            }
            if (lblName.Text == "Hồ Núi Cốc")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Hồ_Núi_Cốc;
                Addmarker("Hồ Núi Cốc", 21.584080, 105.697171);
            }
            if (lblName.Text == "Hồ Quan Sơn")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Hồ_Quan_Sơn;
                Addmarker("Hồ Quan Sơn", 20.695687, 105.695684);
            }
            if (lblName.Text == "Côn Sơn Kiếp Bạc")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Côn_Sơn_Kiếp_Bạc;
                Addmarker("Côn Sơn Kiếp Bạc", 21.148942, 106.383218);
            }
            if (lblName.Text == "Đỉnh Lảo Thẩn")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Đỉnh_Lảo_Thẩn;
                Addmarker("Đỉnh Lảo Thần", 22.610228, 103.686679);
            }
            if (lblName.Text == "Tà Xùa")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Tà_Xùa;
                Addmarker("Tà Xùa", 21.278821, 104.466507);
            }
            if (lblName.Text == "Bạch Mộc Lương Tử")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Bạch_Mộc_Lương_Tử;
                Addmarker("Bạch Mộc Lương Tử", 22.507051, 103.587849);
            }
            if (lblName.Text == "Núi Muối")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Núi_Muối;
                Addmarker("Núi Muối", 11.322574, 108.911977);
            }
            if (lblName.Text == "Háng Đồng")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Háng_Đồng;
                Addmarker("Háng Đồng", 21.327504, 104.507787);
            }
            if (lblName.Text == "Y Tý")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Y_Tý;
                Addmarker("Y Tý", 22.657941, 103.614259);
            }
            if (lblName.Text == "Sìn Hồ")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Sìn_Hồ;
                Addmarker("Sìn Hồ", 22.357132, 103.249715);
            }
            if (lblName.Text == "Pù Luông")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Pù_Luông;
                Addmarker("Pù Luông", 20.467804, 105.172564);

            }
            if (lblName.Text == "Bà Nà")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Bà_Nà;
                Addmarker("Bà Nà", 15.997880, 107.988066);
            }
            if (lblName.Text == "Đảo Lý Sơn")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Đảo_Lý_Sơn;
                Addmarker("Đảo Lý Sơn", 15.383641, 109.110747);
            }
            if (lblName.Text == "Cù Lao Xanh")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Cù_Lao_Xanh;
                Addmarker("Cù Lao Xanh", 13.623443, 109.345711);
            }
            if (lblName.Text == "Biển Bình Tiên")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Biển_Bình_Tiên;
                Addmarker("Biển Bình Tiên", 11.801327, 109.185468);
            }
            if (lblName.Text == "Đảo Phú Quý")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Đảo_Phú_Quý;
                Addmarker("Đảo Phú Quý", 10.522944, 108.944624);
            }
            if (lblName.Text == "Động Thiên Đường")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Động_Thiên_Đường;
                Addmarker("Động Thiên Đường", 17.521446, 106.219679);
            }
            if (lblName.Text == "Vườn quốc gia Pù Mát")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Vườn_quốc_gia_Pù_Mát;
                Addmarker("Vườn quốc gia Pù Mát", 19.057903, 104.860299);
            }
            if (lblName.Text == "Suối Cá Thần Cẩm Lương")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Suối_Cá_Thần_Cẩm_Lương;
                Addmarker("Suối Cá Thần Cẩm Lương", 20.251421, 105.390999);
            }
            if (lblName.Text == "Vực Phun")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Vực_Phun;
                Addmarker("Vực Phun", 12.876265, 109.128547);
            }
            if (lblName.Text == "Vịnh Vũng Rô")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Vịnh_Vũng_Rô;
                Addmarker("Vịnh Vũng Rô", 12.867813, 109.423795);
            }
            if (lblName.Text == "Bến En")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Bến_En;
                Addmarker("Bến En", 19.618145, 105.529568);
            }
            if (lblName.Text == "Biển Sầm Sơn")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Biển_Sầm_Sơn;
                Addmarker("Biển Sầm Sơn", 19.745718, 105.907583);
            }
            if (lblName.Text == "Cà Mau")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Cà_Mau;
                Addmarker("Cà Mau", 9.153008, 105.196251);
            }
            if (lblName.Text == "Biển Thiên Cầm")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Biển_Thiên_Cầm;
                Addmarker("Biển Thiên Cầm", 18.271269, 106.108687);
            }
            if (lblName.Text == "Thung Nham - Thung Chim")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Thung_Nham___Thung_Chim;
                Addmarker("Thung Nham - Thung Chim", 20.221295, 105.891077);
            }
            if (lblName.Text == "Đèo Hải Vân – Đầm Lập An")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Đèo_Hải_Vân___Đầm_Lập_An;
                Addmarker("Đèo Hải Vân", 16.183664, 108.089678);
                Addmarker("Đầm Lập An", 16.233227, 108.078543);
            }
            if (lblName.Text == "Vườn Quốc Gia Bạch Mã")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Vườn_Quốc_Gia_Bạch_Mã;
                Addmarker("Vườn Quốc Gia Bạch Mã", 16.249600, 107.872615);
            }
            if (lblName.Text == "Đèo A Co – Thác A Nor")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Đèo_A_Co___Thác_A_Nor;
                Addmarker("Thác A Nor", 16.306056, 107.214416);
            }
            if (lblName.Text == "Thành Phố Hồ Chí Minh")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Thành_Phố_Hồ_Chí_Minh;
                Addmarker("Thành Phố Hồ Chí Minh", 10.822926, 106.629835);
            }
            if (lblName.Text == "Khe Tre - Thác Mơ")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Khe_Tre___Thác_Mơ;
                Addmarker("Khe Tre", 16.172052, 107.718695);
                Addmarker("Thác Mơ", 16.210254, 107.723801);
            }
            if (lblName.Text == "Biển An Bàng")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Biển_An_Bàng;
                Addmarker("Biển An Bàng", 16.423543, 107.833115);
            }
            if (lblName.Text == "Cù Lao Chàm")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Cù_Lao_Chàm;
                Addmarker("Cù Lao Chàm", 15.958965, 108.507814);
            }
            if (lblName.Text == "Đà Lạt")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Đà_Lạt;
                Addmarker("Đà Lạt", 11.939911, 108.458656);
            }
            if (lblName.Text == "Nam Du")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Nam_Du;
                Addmarker("Nam Du", 9.682481, 104.352663);
            }
            if (lblName.Text == "Đường ven biển Ninh Thuận")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Đường_ven_biển_Ninh_Thuận;
                Addmarker("Biển Ninh Thuận", 11.328771, 108.972832);
            }
            if (lblName.Text == "Bảo Lộc - Đà Lạt – Dran")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Bảo_Lộc___Đà_Lạt___Dran;
                Addmarker("Bảo Lộc",11.572933, 107.835207);
            }
            if (lblName.Text == "Bình Ba")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Bình_Ba;
                Addmarker("Bình Ba", 11.837179, 109.232860);
            }
            if (lblName.Text == "Bình Lập")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Bình_Lập;
                Addmarker("Bình Lập", 11.851349, 109.171481);
            }
            if (lblName.Text == "Bình Hưng")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Bình_Hưng;
                Addmarker("Bình Hưng", 11.777869, 109.217526);
            }
            if (lblName.Text == "Đèo Pêke")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Đèo_Pêke;
                Addmarker("Đèo Pêke", 16.403362, 107.092972);
            }
            if (lblName.Text == "Phú Quốc")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Phú_Quốc;
                Addmarker("Phú Quốc", 10.286712, 103.978089);
            }
            if (lblName.Text == "Vũng Tàu")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Vũng_Tàu;
                Addmarker("Vũng Tàu", 10.411882, 107.136567);
            }
            if (lblName.Text == "Long An")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Long_An;
                Addmarker("Long An", 10.538337, 106.405473);
            }
            if (lblName.Text == "Tiền Giang")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Tiền_Giang;
                Addmarker("Tiền Giang", 10.449666, 106.341364);
            }
            if (lblName.Text == "Bến Tre")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Bến_Tre;
                Addmarker("Bến Tre", 10.242507, 106.376238);
            }
            if (lblName.Text == "Trà Vinh")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Trà_Vinh;
                Addmarker("Trà Vinh", 9.951497, 106.334263);
            }
            if (lblName.Text == "Sóc Trăng")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Sóc_Trăng;
                Addmarker("Sóc Trăng", 9.602856, 105.973390);
            }
            if (lblName.Text == "Cần Thơ")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Cần_Thơ;
                Addmarker("Cần Thơ", 10.045665, 105.747197);
            }
            if (lblName.Text == "Vĩnh Long")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Vĩnh_Long;
                Addmarker("Vĩnh Long", 10.239401, 105.957021);
            }
            if (lblName.Text == "Đồng Tháp")
            {
                lblName.Image = TravelPlannerApp.Properties.Resources.Đồng_Tháp;
                Addmarker("Đồng Tháp", 10.494639, 105.687836);
            }
        }
        private void lblName_Click(object sender, EventArgs e)
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
            gMapControl1.MapProvider = GMapProviders.BingMap;
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
            //table.Rows.Add("Yours places", 10.854309, 106.650977);
            return table;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GetRoute_Click(object sender, EventArgs e)
        {
            
            if(lblName.Text=="Mộc Châu")
            {
                Direction d = new Direction();
                d.SenderP("Mộc Châu");
                d.ShowDialog();
            }

        }
        private void GetPoints(double Lat,double Lng)
        {
            _points.Add(new PointLatLng(Lat, Lng));
            _points.Add(new PointLatLng(10.854309, 106.650977));
        }
    }
}
