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
    public partial class SouthSide : Form
    {
        public SouthSide()
        {
            InitializeComponent();
        }
        public void SouthPlaces()
        {
            //Mekong Delta
            for (int i = 1; i < 11; i++)
            {
                Button btn = new Button();
                if (i == 1)
                {
                    btn.Text = "Cà Mau";
                }
                if (i == 2)
                {
                    btn.Text = "Nam Du (Kiên Giang)";
                }
                if (i == 3)
                {
                    btn.Text = "Phú Quốc (Kiên Giang)";
                }
                if (i == 4)
                {
                    btn.Text = "Long An";
                }
                if (i == 5)
                {
                    btn.Text = "Tiền Giang";
                }
                if (i == 6)
                {
                    btn.Text = "Bến Tre";
                }
                if (i == 7)
                {
                    btn.Text = "Trà Vinh";
                }
                if (i == 8)
                {
                    btn.Text = "Sóc Trăng";
                }
                if (i == 9)
                {
                    btn.Text = "Vĩnh Long";
                }
                if (i == 10)
                {
                    btn.Text = "Đồng Tháp";
                }
                btn.AutoSize = true;
                btn.Location = new Point(20, panel1.Controls.Count * 30);
                panel1.Controls.Add(btn);
            }
            //Hồ Chí Minh city và các tỉnh lân cận
            for (int i = 1; i < 5; i++)
            {
                Button btn = new Button();
                if (i == 1)
                {
                    btn.Text = "Thành Phố Hồ Chí Minh";
                }
                if (i == 2)
                {
                    btn.Text = "Bình Hưng";
                }
                if (i == 3)
                {
                    btn.Text = "Cần Thơ";
                }
                if (i == 4)
                {
                    btn.Text = "Vũng Tàu";
                }
                btn.AutoSize = true;
                btn.Location = new Point(20, panel2.Controls.Count * 30);
                panel2.Controls.Add(btn);
            }
            //Highlands
            for (int i = 1; i < 3; i++)
            {
                Button btn = new Button();
                if (i == 1)
                {
                    btn.Text = "Đà Lạt(Lâm Đồng)";
                }
                if (i == 2)
                {
                    btn.Text = "Bảo Lộc - Đà Lạt - Dran (Đà Lạt)";
                }
                btn.AutoSize = true;
                btn.Location = new Point(20, panel3.Controls.Count * 30);
                panel3.Controls.Add(btn);
            }
        }

        private void SouthSide_Load(object sender, EventArgs e)
        {
            SouthPlaces();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
