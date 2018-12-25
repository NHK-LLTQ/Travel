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
                    btn.Click += Btn_Click;
                }
                if (i == 2)
                {
                    btn.Text = "Mai Châu";
                    btn.Click += Btn_Click1;
                }
                if (i == 3)
                {
                    btn.Text = "Thác Háng Tề Chơ";
                    btn.Click += Btn_Click2;
                }
                if (i == 4)
                {
                    btn.Text = "Sapa";
                    btn.Click += Btn_Click3;
                }
                if (i == 5)
                {
                    btn.Text = "Hồ Pa Khoang";
                    btn.Click += Btn_Click4;
                }
                if (i == 6)
                {
                    btn.Text = "Đỉnh Lảo Thần";
                    btn.Click += Btn_Click5;
                }
                if (i == 7)
                {
                    btn.Text = "Tà Xùa";
                    btn.Click += Btn_Click6;
                }
                if (i == 8)
                {
                    btn.Text = "Bạch Mộc Lương Tử";
                    btn.Click += Btn_Click7;
                }
                if (i == 9)
                {
                    btn.Text = "Núi Muối";
                    btn.Click += Btn_Click8;
                }
                if (i == 10)
                {
                    btn.Text = "Háng Đồng";
                    btn.Click += Btn_Click9;
                }
                if (i == 11)
                {
                    btn.Text = "Y Tý";
                    btn.Click += Btn_Click10;
                }
                if (i == 12)
                {
                    btn.Text = "Sìn Hồ";
                    btn.Click += Btn_Click11;
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
                    btn.Click += Btn_Click12;
                }
                if (j == 2)
                {
                    btn.Text = "Mù Cang Chải";
                    btn.Click += Btn_Click13;
                }
                if (j == 3)
                {
                    btn.Text = "Đồng Cao";
                    btn.Click += Btn_Click14;
                }
                if (j == 4)
                {
                    btn.Text = "Thác Bản Giốc";
                    btn.Click += Btn_Click15;
                }
                if (j == 5)
                {
                    btn.Text = "Vườn Quốc Gia Ba Vì";
                    btn.Click += Btn_Click16;
                }
                if (j == 6)
                {
                    btn.Text = "Hồ Thung Nai";
                    btn.Click += Btn_Click17;
                }
                if (j == 7)
                {
                    btn.Text = "Vịnh Lan Hạ";
                    btn.Click += Btn_Click18;
                }
                if (j == 8)
                {
                    btn.Text = "Tây Yên Tử";
                    btn.Click += Btn_Click19;
                }
                if (j == 9)
                {
                    btn.Text = "Bãi Dài";
                    btn.Click += Btn_Click20;
                }
                if (j == 10)
                {
                    btn.Text = "Bình Liêu";
                    btn.Click += Btn_Click21;
                }
                if (j == 11)
                {
                    btn.Text = "Hồ Núi Cốc";
                    btn.Click += Btn_Click22;
                }
                if (j == 12)
                {
                    btn.Text = "Hồ Quan Sơn";
                    btn.Click += Btn_Click23;
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
                    btn.Click += Btn_Click24;
                }
                if(k==2)
                {
                    btn.Text = "Vườn Quốc Gia Xuân Sơn";
                    btn.Click += Btn_Click25;
                }
                if(k==3)
                {
                    btn.Text = "Côn Sơn Kiếp Bạc";
                    btn.Click += Btn_Click26;
                }
                btn.AutoSize = true;
                btn.Location = new Point(10, panel3.Controls.Count * 30);
                panel3.Controls.Add(btn);
            }
        }

        private void Btn_Click26(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Côn Sơn Kiếp Bạc");
            form.ShowDialog();
        }

        private void Btn_Click25(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Vườn Quốc gia Xuân Sơn");
            form.ShowDialog();
        }

        private void Btn_Click24(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Tam Đảo");
            form.ShowDialog();

        }

        private void Btn_Click23(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Hồ Quan Sơn");
            form.ShowDialog();
        }

        private void Btn_Click22(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Hồ Núi Cốc");
            form.ShowDialog();
        }

        private void Btn_Click21(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Bình Liêu");
            form.ShowDialog();
        }

        private void Btn_Click20(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Bãi Dài");
            form.ShowDialog();
        }

        private void Btn_Click19(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Tây Yên Tử");
            form.ShowDialog();
        }

        private void Btn_Click18(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Vịnh Lan Hạ");
            form.ShowDialog();
        }

        private void Btn_Click17(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Hồ Thung Nai");
            form.ShowDialog();
        }

        private void Btn_Click16(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Vườn quốc gia Ba Vì");
            form.ShowDialog();
        }

        private void Btn_Click15(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Thác Bản Giốc");
            form.ShowDialog();
        }

        private void Btn_Click14(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Đồng Cao");
            form.ShowDialog();
        }

        private void Btn_Click13(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Mù Cang Chải");
            form.ShowDialog();
        }

        private void Btn_Click12(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Hàm Lợn");
            form.ShowDialog();
        }

        private void Btn_Click11(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Sìn Hồ");
            form.ShowDialog();
        }

        private void Btn_Click10(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Y Tý");
            form.ShowDialog();
        }

        private void Btn_Click9(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Háng Đồng");
            form.ShowDialog();
        }

        private void Btn_Click8(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Núi Muối");
            form.ShowDialog();
        }

        private void Btn_Click7(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Bạch Mộc Lương Tử");
            form.ShowDialog();
        }

        private void Btn_Click6(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Tà Xùa");
            form.ShowDialog();
        }

        private void Btn_Click5(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Đỉnh Lảo Thẩn");
            form.ShowDialog();
        }

        private void Btn_Click4(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Hồ Pa Khoang");
            form.ShowDialog();
        }

        private void Btn_Click3(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("SaPa");
            form.ShowDialog();
        }

        private void Btn_Click2(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Háng Tề Chơ");
            form.ShowDialog();
        }

        private void Btn_Click1(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Mai Châu");
            form.ShowDialog();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Mộc Châu");
            form.ShowDialog();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();
            
        }
    }
}

