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
    public partial class Central : Form
    {
        public Central()
        {
            InitializeComponent();
        }
        private void Central_Load(object sender, EventArgs e)
        {
            CentralPlaces();
        }
        public void CentralPlaces()
        {
            //North Central
            for(int i=1;i<13;i++)
            {
                Button btn = new Button();
                if (i == 1)
                {
                    btn.Text = "Pù Luông (Thanh Hóa)";
                }
                if (i == 2)
                {
                    btn.Text = "Động Thiên Đường (Quảng Bình)";
                }
                if (i == 3)
                {
                    btn.Text = "Vườn quốc gia Pù Mát (Nghệ An)";
                }
                if (i == 4)
                {
                    btn.Text = "Suối Cá Thần Cẩm Lương (Thanh Hóa)";
                }
                if (i == 5)
                {
                    btn.Text = "Bến En (Thanh Hóa)";
                }
                if (i == 6)
                {
                    btn.Text = "Biển Sầm Sơn (Thanh Hóa)";
                }
                if (i == 7)
                {
                    btn.Text = "Biển Thiên Cầm (Hà Tĩnh)";
                }
                if (i == 8)
                {
                    btn.Text = "Đèo Hải Vân – Đầm Lập An (Thừa Thiên Huế)";
                }
                if (i == 9)
                {
                    btn.Text = "Vườn Quốc Gia Bạch Mã  (Huế)";
                }
                if (i == 10)
                {
                    btn.Text = "Đèo A Co – Thác A Nor (Huế)";
                }
                if (i == 11)
                {
                    btn.Text = "Khe Tre - Thác Mơ";
                }
                if (i == 12)
                {
                    btn.Text = "Đèo Pêke";
                }
                btn.AutoSize = true;
                btn.Location = new Point(20, panel1.Controls.Count * 30);
                panel1.Controls.Add(btn);
            }
            //South Central
            for(int i=1;i<13;i++)
            {
                Button btn = new Button();
                if (i == 1)
                {
                    btn.Text = "Bà Nà (Đà Nẵng)";
                }
                if (i == 2)
                {
                    btn.Text = "Đảo Lý Sơn (Quảng Ngãi)";
                }
                if (i == 3)
                {
                    btn.Text = "Cù Lao Xanh (Bình Định)";
                }
                if (i == 4)
                {
                    btn.Text = "Biển Bình Tiên (Ninh Thuận)";
                }
                if (i == 5)
                {
                    btn.Text = "Đảo Phú Quý (Bình Thuận)";
                }
                if (i == 6)
                {
                    btn.Text = "Vực Phun (Phú Yên)";
                }
                if (i == 7)
                {
                    btn.Text = "Vịnh Vũng Rô (Phú Yên)";
                }
                if (i == 8)
                {
                    btn.Text = "Biển An Bàng";
                }
                if (i == 9)
                {
                    btn.Text = "Cù Lao Chàm";
                }
                if (i == 10)
                {
                    btn.Text = "Đường ven biển Ninh Thuận";
                }
                if (i == 11)
                {
                    btn.Text = "Bình Ba";
                }
                if (i == 12)
                {
                    btn.Text = "Bình Lập";
                }
                btn.AutoSize = true;
                btn.Location = new Point(20, panel2.Controls.Count * 30);
                panel2.Controls.Add(btn);
            }
        }
    }
}
