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
    public partial class NorthSide : Form
    {
        public NorthSide()
        {
            InitializeComponent();
        }

        private void NorthSide_Load(object sender, EventArgs e)
        {
            Places();
        }
        public void Places()
        {
            for(int i=1;i<29;i++)
            {
                Button btn = new Button();
                if(i==1)
                {
                    btn.Text = "Mộc Châu(Sơn La)";
                    btn.Click += Btn_Click1;
                }
                if (i == 2)
                {
                    btn.Text = "Mai Châu ( Hòa Bình)";
                    btn.Click += Btn_Click2;
                }
                if (i == 3)
                {
                    btn.Text = "Tam Đảo (Vĩnh Phúc)";
                    btn.Click += Btn_Click3;
                }
                if (i == 4)
                {
                    btn.Text = "Hàm Lợn (Hà Nội)";
                    btn.Click += Btn_Click4;
                }
                if (i == 5)
                {
                    btn.Text = "Háng Tề Chơ(Yên Bái)";
                    btn.Click += Btn_Click5;
                }
                if (i == 6)
                {
                    btn.Text = "Mù Cang Chải (Yên Bái)";
                    btn.Click += Btn_Click6;
                }
                if (i == 7)
                {
                    btn.Text = "Sapa (Lào Cai)";
                    btn.Click += Btn_Click7;
                }
                if (i == 8)
                {
                    btn.Text = "Hồ Pa Khoang (Điện Biên)";
                    btn.Click += Btn_Click8;
                }
                if (i == 9)
                {
                    btn.Text = "Vườn Quốc gia Xuân Sơn (Phú Thọ)";
                    btn.Click += Btn_Click9;
                }
                if (i == 10)
                {
                    btn.Text = "Đồng Cao (Bắc Giang)";
                    btn.Click += Btn_Click10;
                }
                if (i == 11)
                {
                    btn.Text = "Thác Bản Giốc (Cao Bằng)";
                    btn.Click += Btn_Click11;
                }
                if (i == 12)
                {
                    btn.Text = "Vườn quốc gia Ba Vì (Hà Nội)";
                    btn.Click += Btn_Click12;
                }
                if (i == 13)
                {
                    btn.Text = "Hồ Thung Nai (Hòa Bình)";
                    btn.Click += Btn_Click13;
                }
                if (i == 14)
                {
                    btn.Text = "Vịnh Lan Hạ (Hải Phòng)";
                    btn.Click += Btn_Click14;
                }
                if (i == 15)
                {
                    btn.Text = "Tây Yên Tử (Quảng Ninh)";
                    btn.Click += Btn_Click15;
                }
                if (i == 16)
                {
                    btn.Text = "Bãi Dài (Quảng Ninh)";
                    btn.Click += Btn_Click16;
                }
                if (i == 17)
                {
                    btn.Text = "Bình Liêu (Quảng Ninh)";
                    btn.Click += Btn_Click17;
                }
                if (i == 18)
                {
                    btn.Text = "Hồ Núi Cốc (Thái Nguyên)";
                    btn.Click += Btn_Click18;
                }
                if (i == 19)
                {
                    btn.Text = "Hồ Quan Sơn (Hà Nội)";
                    btn.Click += Btn_Click19;
                }
                if (i == 20)
                {
                    btn.Text = "Côn Sơn Kiếp Bạc (Hải Dương)";
                    btn.Click += Btn_Click20;
                }
                if (i == 21)
                {
                    btn.Text = "Đỉnh Lảo Thẩn (Lào Cai)";
                    btn.Click += Btn_Click21;
                }
                if (i == 22)
                {
                    btn.Text = "Tà Xùa (Sơn La)";
                    btn.Click += Btn_Click22;
                }
                if (i == 23)
                {
                    btn.Text = "Bạch Mộc Lương Tử (Lào Cai)";
                    btn.Click += Btn_Click23;
                }
                if (i == 24)
                {
                    btn.Text = "Núi Muối (Lào Cai)";
                    btn.Click += Btn_Click24;
                }
                if (i == 25)
                {
                    btn.Text = "Háng Đồng (Sơn La)";
                    btn.Click += Btn_Click25;
                }
                if (i == 26)
                {
                    btn.Text = "Y Tý (Lào Cai)";
                    btn.Click += Btn_Click26;
                }
                if (i == 27)
                {
                    btn.Text = "Sìn Hồ (Lai Châu)";
                    btn.Click += Btn_Click27;
                }
                if (i == 28)
                {
                    btn.Text = "Thung Nham - Thung Chim (Ninh Bình)";
                    btn.Click += Btn_Click43;
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
            form.Sender("Mộc Châu");
            form.ShowDialog();
        }
        private void Btn_Click2(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Mai Châu");
            form.ShowDialog();
        }
        private void Btn_Click3(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Tam Đảo");
            form.ShowDialog();
        }
        private void Btn_Click4(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Hàm Lợn");
            form.ShowDialog();
        }
        private void Btn_Click5(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Háng Tề Chơ");
            form.ShowDialog();
        }
        private void Btn_Click6(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Mù Cang Chải");
            form.ShowDialog();
        }
        private void Btn_Click7(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("SaPa");
            form.ShowDialog();
        }
        private void Btn_Click8(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Hồ Pa Khoang");
            form.ShowDialog();
        }
        private void Btn_Click9(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Vườn Quốc gia Xuân Sơn");
            form.ShowDialog();
        }
        private void Btn_Click10(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Đồng Cao");
            form.ShowDialog();
        }
        private void Btn_Click11(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Thác Bản Giốc");
            form.ShowDialog();
        }
        private void Btn_Click12(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Vườn quốc gia Ba Vì");
            form.ShowDialog();
        }
        private void Btn_Click13(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Hồ Thung Nai");
            form.ShowDialog();
        }
        private void Btn_Click14(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Vịnh Lan Hạ");
            form.ShowDialog();
        }
        private void Btn_Click15(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Tây Yên Tử");
            form.ShowDialog();
        }
        private void Btn_Click16(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Bãi Dài");
            form.ShowDialog();
        }
        private void Btn_Click17(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Bình Liêu");
            form.ShowDialog();
        }
        private void Btn_Click18(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Hồ Núi Cốc");
            form.ShowDialog();
        }
        private void Btn_Click19(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Hồ Quan Sơn");
            form.ShowDialog();
        }
        private void Btn_Click20(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Côn Sơn Kiếp Bạc");
            form.ShowDialog();
        }
        private void Btn_Click21(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Đỉnh Lảo Thẩn");
            form.ShowDialog();
        }
        private void Btn_Click22(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Tà Xùa");
            form.ShowDialog();
        }
        private void Btn_Click23(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Bạch Mộc Lương Tử");
            form.ShowDialog();
        }
        private void Btn_Click24(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Núi Muối");
            form.ShowDialog();
        }
        private void Btn_Click25(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Háng Đồng");
            form.ShowDialog();
        }
        private void Btn_Click26(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Y Tý");
            form.ShowDialog();
        }
        private void Btn_Click27(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Sìn Hồ");
            form.ShowDialog();
        }
        private void Btn_Click43(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Thung Nham - Thung Chim");
            form.ShowDialog();
        }
    }
}
