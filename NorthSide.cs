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
    public partial class NorthSide : Form
    {
        public NorthSide()
        {
            InitializeComponent();
        }

        private void NorthSide_Load(object sender, EventArgs e)
        {
            NorthPlaces();

        }
        protected void NorthPlaces()
        {
            
           
            //NorthWest
            for (int i = 1; i <= 12; i++)
            {
                Button btn = new Button();
                if (i == 1)
                {
                    btn.Text = "Mộc Châu";
                }
                if (i == 2)
                {
                    btn.Text = "Mai Châu";
                }
                if (i == 3)
                {
                    btn.Text = "Thác Háng Tề Chơ";
                }
                if (i == 4)
                {
                    btn.Text = "Sapa";
                }
                if (i == 5)
                {
                    btn.Text = "Hồ Pa Khoang";
                }
                if (i == 6)
                {
                    btn.Text = "Đỉnh Lảo Thần";
                }
                if (i == 7)
                {
                    btn.Text = "Tà Xùa";
                }
                if (i == 8)
                {
                    btn.Text = "Bạch Mộc Lương Tử";
                }
                if (i == 9)
                {
                    btn.Text = "Núi Muối";
                }
                if (i == 10)
                {
                    btn.Text = "Háng Đồng";
                }
                if (i == 11)
                {
                    btn.Text = "Y Tý";
                }
                if (i == 12)
                {
                    btn.Text = "Sìn Hồ";
                }
               
                btn.AutoSize = true;
                btn.Location = new Point(20, panel1.Controls.Count * 30);
                panel1.Controls.Add(btn);
            }
            //Northeast
            for(int j=1;j<=12;j++)
            {
                Button btn = new Button();
                if (j == 1)
                {
                    btn.Text = "Hàm lợn";
                }
                if (j == 2)
                {
                    btn.Text = "Mù Cang Chải";
                }
                if (j == 3)
                {
                    btn.Text = "Đồng Cao";
                }
                if (j == 4)
                {
                    btn.Text = "Thác Bản Giốc";
                }
                if (j == 5)
                {
                    btn.Text = "Vườn Quốc Gia Ba Vì";
                }
                if (j == 6)
                {
                    btn.Text = "Hồ Thung Nai";
                }
                if (j == 7)
                {
                    btn.Text = "Vịnh Lan Hạ";
                }
                if (j == 8)
                {
                    btn.Text = "Tây Yên Tử";
                }
                if (j == 9)
                {
                    btn.Text = "Bãi Dài";
                }
                if (j == 10)
                {
                    btn.Text = "Bình Liêu";
                }
                if (j == 11)
                {
                    btn.Text = "Hồ Núi Cốc";
                }
                if (j == 12)
                {
                    btn.Text = "Hồ Quan Sơn";
                }
                btn.AutoSize = true;
                btn.Location = new Point(20, panel2.Controls.Count * 30);
                panel2.Controls.Add(btn);
            }
            //Red River Delta
            for(int k=1;k<=3;k++)
            {
                Button btn = new Button();
                if(k==1)
                {
                    btn.Text = "Tam Đảo";
                }
                if(k==2)
                {
                    btn.Text = "Vườn Quốc Gia Xuân Sơn";
                }
                if(k==3)
                {
                    btn.Text = "Côn Sơn Kiếp Bạc";
                }
                btn.AutoSize = true;
                btn.Location = new Point(10, panel3.Controls.Count * 30);
                panel3.Controls.Add(btn);
            }
        }
    }
}

