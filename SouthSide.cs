using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace TravelPlannerApp
{
    public partial class SouthSide : Form
    {
        public SouthSide()
        {
            InitializeComponent();
        }

        private void SouthSide_Load(object sender, EventArgs e)
        {
            Places();
        }
        public void Places()
        {
            for(int i=0;i<17;i++)
            {
                Button btn = new Button();
                if (i == 1)
                {
                    btn.Text = "Cà Mau";
                    btn.Click += Btn_Click1;
                }
                if (i == 2)
                {
                    btn.Text = "Thành Phố Hồ Chí Minh";
                    btn.Click += Btn_Click2;
                }
                if (i == 3)
                {
                    btn.Text = "Đà Lạt (Lâm Đồng)";
                    btn.Click += Btn_Click3;
                }
                if (i == 4)
                {
                    btn.Text = "Nam Du (Kiên Giang)";
                    btn.Click += Btn_Click4;
                }
                if (i == 5)
                {
                    btn.Text = "Bảo Lộc - Đà Lạt - Dran (Đà Lạt)";
                    btn.Click += Btn_Click5;
                }
                if (i == 6)
                {
                    btn.Text = "Bình Hưng";
                    btn.Click += Btn_Click6;
                }
                if (i == 7)
                {
                    btn.Text = "Phú Quốc (Kiên Giang)";
                    btn.Click += Btn_Click7;
                }
                if (i == 8)
                {
                    btn.Text = "Vũng Tàu";
                    btn.Click += Btn_Click8;
                }
                if (i == 9)
                {
                    btn.Text = "Long An";
                    btn.Click += Btn_Click9;
                }
                if (i == 10)
                {
                    btn.Text = "Tiền Giang";
                    btn.Click += Btn_Click10;
                }
                if (i == 11)
                {
                    btn.Text = "Bến Tre";
                    btn.Click += Btn_Click11;
                }
                if (i == 12)
                {
                    btn.Text = "Trà Vinh";
                    btn.Click += Btn_Click12;
                }
                if (i == 13)
                {
                    btn.Text = "Sóc Trăng";
                    btn.Click += Btn_Click13;
                }
                if (i == 14)
                {
                    btn.Text = "Cần Thơ";
                    btn.Click += Btn_Click14;
                }
                if (i == 15)
                {
                    btn.Text = "Vĩnh Long";
                    btn.Click += Btn_Click15;
                }
                if (i == 16)
                {
                    btn.Text = "Đồng Tháp";
                    btn.Click += Btn_Click16;
                }
                btn.AutoSize = true;
                btn.Location = new Point(10, panel1.Controls.Count * 25);
                panel1.Controls.Add(btn);
            }
        }
        private void Btn_Click1(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Cà Mau");
            form.ShowDialog();
        }
        private void Btn_Click2(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Thành Phố Hồ Chí Minh");
            form.ShowDialog();
        }
        private void Btn_Click3(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Đà Lạt");
            form.ShowDialog();
        }
        private void Btn_Click4(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Nam Du");
            form.ShowDialog();
        }
        private void Btn_Click5(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Bảo Lộc - Đà Lạt – Dran");
            form.ShowDialog();
        }
        private void Btn_Click6(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Bình Hưng");
            form.ShowDialog();
        }
        private void Btn_Click7(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Phú Quốc");
            form.ShowDialog();
        }
        private void Btn_Click8(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Vũng Tàu");
            form.ShowDialog();
        }
        private void Btn_Click9(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Long An");
            form.ShowDialog();
        }
        private void Btn_Click10(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Tiền Giang");
            form.ShowDialog();
        }
        private void Btn_Click11(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Bến Tre");
            form.ShowDialog();
        }
        private void Btn_Click12(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Trà Vinh");
            form.ShowDialog();
        }
        private void Btn_Click13(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Sóc Trăng");
            form.ShowDialog();
        }
        private void Btn_Click14(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Cần Thơ");
            form.ShowDialog();
        }
        private void Btn_Click15(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Vĩnh Long");
            form.ShowDialog();
        }
        private void Btn_Click16(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Đồng Tháp");
            form.ShowDialog();
        }
    }
}
