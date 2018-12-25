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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void CentralPlaces()
        {
            //North Central
            for (int i = 1; i < 13; i++)
            {
                Button btn = new Button();
                if (i == 1)
                {
                    btn.Text = "Pù Luông (Thanh Hóa)";
                    btn.Click += Btn_Click;
                }
                if (i == 2)
                {
                    btn.Text = "Động Thiên Đường (Quảng Bình)";
                    btn.Click += Btn_Click1;
                }
                if (i == 3)
                {
                    btn.Text = "Vườn quốc gia Pù Mát (Nghệ An)";
                    btn.Click += Btn_Click2;
                }
                if (i == 4)
                {
                    btn.Text = "Suối Cá Thần Cẩm Lương (Thanh Hóa)";
                    btn.Click += Btn_Click3;
                }
                if (i == 5)
                {
                    btn.Text = "Bến En (Thanh Hóa)";
                    btn.Click += Btn_Click4;
                }
                if (i == 6)
                {
                    btn.Text = "Biển Sầm Sơn (Thanh Hóa)";
                    btn.Click += Btn_Click5;
                }
                if (i == 7)
                {
                    btn.Text = "Biển Thiên Cầm (Hà Tĩnh)";
                    btn.Click += Btn_Click6;
                }
                if (i == 8)
                {
                    btn.Text = "Đèo Hải Vân – Đầm Lập An (Thừa Thiên Huế)";
                    btn.Click += Btn_Click7;
                }
                if (i == 9)
                {
                    btn.Text = "Vườn Quốc Gia Bạch Mã  (Huế)";
                    btn.Click += Btn_Click8;
                }
                if (i == 10)
                {
                    btn.Text = "Đèo A Co – Thác A Nor (Huế)";
                    btn.Click += Btn_Click9;
                }
                if (i == 11)
                {
                    btn.Text = "Khe Tre - Thác Mơ";
                    btn.Click += Btn_Click10;
                }
                if (i == 12)
                {
                    btn.Text = "Đèo Pêke";
                    btn.Click += Btn_Click11;
                }
                btn.AutoSize = true;
                btn.Location = new Point(20, panel1.Controls.Count * 30);
                panel1.Controls.Add(btn);
            }
            //South Central
            for (int i = 1; i < 13; i++)
            {
                Button btn = new Button();
                if (i == 1)
                {
                    btn.Text = "Bà Nà (Đà Nẵng)";
                    btn.Click += Btn_Click12;
                }
                if (i == 2)
                {
                    btn.Text = "Đảo Lý Sơn (Quảng Ngãi)";
                    btn.Click += Btn_Click13;
                }
                if (i == 3)
                {
                    btn.Text = "Cù Lao Xanh (Bình Định)";
                    btn.Click += Btn_Click14;
                }
                if (i == 4)
                {
                    btn.Text = "Biển Bình Tiên (Ninh Thuận)";
                    btn.Click += Btn_Click15;
                }
                if (i == 5)
                {
                    btn.Text = "Đảo Phú Quý (Bình Thuận)";
                    btn.Click += Btn_Click16;
                }
                if (i == 6)
                {
                    btn.Text = "Vực Phun (Phú Yên)";
                    btn.Click += Btn_Click17;
                }
                if (i == 7)
                {
                    btn.Text = "Vịnh Vũng Rô (Phú Yên)";
                    btn.Click += Btn_Click18;
                }
                if (i == 8)
                {
                    btn.Text = "Biển An Bàng";
                    btn.Click += Btn_Click19;
                }
                if (i == 9)
                {
                    btn.Text = "Cù Lao Chàm";
                    btn.Click += Btn_Click20;
                }
                if (i == 10)
                {
                    btn.Text = "Đường ven biển Ninh Thuận";
                    btn.Click += Btn_Click21;
                }
                if (i == 11)
                {
                    btn.Text = "Bình Ba";
                    btn.Click += Btn_Click22;
                }
                if (i == 12)
                {
                    btn.Text = "Bình Lập";
                    btn.Click += Btn_Click23;
                }
                btn.AutoSize = true;
                btn.Location = new Point(20, panel2.Controls.Count * 30);
                panel2.Controls.Add(btn);
            }
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Pù Luông");
            form.ShowDialog();
        }
        private void Btn_Click1(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Động Thiên Đường");
            form.ShowDialog();
        }
        private void Btn_Click2(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Vườn quốc gia Pù Mát");
            form.ShowDialog();
        }
        private void Btn_Click3(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Suối Cá Thần Cẩm Lương");
            form.ShowDialog();
        }
        private void Btn_Click4(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Bến En");
            form.ShowDialog();
        }
        private void Btn_Click5(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Biển Sầm Sơn");
            form.ShowDialog();
        }
        private void Btn_Click6(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Biển Thiên Cầm");
            form.ShowDialog();
        }
        private void Btn_Click7(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Đèo Hải Vân – Đầm Lập An");
            form.ShowDialog();
        }
        private void Btn_Click8(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Vườn Quốc Gia Bạch Mã");
            form.ShowDialog();
        }
        private void Btn_Click9(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Đèo A Co – Thác A Nor");
            form.ShowDialog();
        }
        private void Btn_Click10(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Khe Tre - Thác Mơ");
            form.ShowDialog();
        }
        private void Btn_Click11(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Đèo Pêke");
            form.ShowDialog();
        }
        private void Btn_Click12(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Bà Nà");
            form.ShowDialog();
        }
        private void Btn_Click13(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Đảo Lý Sơn");
            form.ShowDialog();
        }
        private void Btn_Click14(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Cù Lao Xanh");
            form.ShowDialog();
        }
        private void Btn_Click15(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Biển Bình Tiên");
            form.ShowDialog();
        }
        private void Btn_Click16(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Đảo Phú Quý");
            form.ShowDialog();
        }
        private void Btn_Click17(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Vực Phun");
            form.ShowDialog();
        }
        private void Btn_Click18(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Vịnh Vũng Rô");
            form.ShowDialog();
        }
        private void Btn_Click19(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Biển An Bàng");
            form.ShowDialog();
        }
        private void Btn_Click20(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Cù Lao Chàm");
            form.ShowDialog();
        }
        private void Btn_Click21(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Đường ven biển Ninh Thuận");
            form.ShowDialog();
        }
        private void Btn_Click22(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Bình Ba");
            form.ShowDialog();
        }
        private void Btn_Click23(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Bình Lập");
            form.ShowDialog();
        }




        private void Central_Load(object sender, EventArgs e)
        {
            CentralPlaces();
        }
    }
}
