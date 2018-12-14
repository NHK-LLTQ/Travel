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
    public partial class Travel : Form
    {
        
        public Travel()
        {
            InitializeComponent();
        
        }
        


       

        private void Travel_Load(object sender, EventArgs e)
        {
            Places();
        }
        protected void Places()
        {
            for (int i = 1; i < 69; i++)
            {
                Button btn = new Button();

                if (i == 1)
                {
                    btn.Text = "Mộc Châu (Sơn La)";
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
                    btn.Text = "Pù Luông (Thanh Hóa)";
                    btn.Click += Btn_Click28;
                }
                if (i == 29)
                {
                    btn.Text = "Bà Nà (Đà Nẵng)";
                    btn.Click += Btn_Click29;
                }
                if (i == 30)
                {
                    btn.Text = "Đảo Lý Sơn (Quảng Ngãi)";
                    btn.Click += Btn_Click30;
                }
                if (i == 31)
                {
                    btn.Text = "Cù Lao Xanh (Bình Định)";
                    btn.Click += Btn_Click31;
                }

                if (i == 32)
                {
                    btn.Text = "Biển Bình Tiên (Ninh Thuận)";
                    btn.Click += Btn_Click32;
                }

                if (i == 33)
                {
                    btn.Text = "Đảo Phú Quý (Bình Thuận)";
                    btn.Click += Btn_Click33;
                }

                if (i == 34)
                {
                    btn.Text = "Động Thiên Đường (Quảng Bình)";
                    btn.Click += Btn_Click34;
                }
                if (i == 35)
                {
                    btn.Text = "Vườn quốc gia Pù Mát (Nghệ An)";
                    btn.Click += Btn_Click35;
                }
                if (i == 36)
                {
                    btn.Text = "Suối Cá Thần Cẩm Lương (Thanh Hóa)";
                    btn.Click += Btn_Click36;
                }
                if (i == 37)
                {
                    btn.Text = "Vực Phun (Phú Yên)";
                    btn.Click += Btn_Click37;
                }
                if (i == 38)
                {
                    btn.Text = "Vịnh Vũng Rô (Phú Yên)";
                    btn.Click += Btn_Click38;
                }

                    if (i == 39)
                    btn.Text = "Bến En (Thanh Hóa)";

                if (i == 40)
                    btn.Text = "Đến biển Sầm Sơn (Thanh Hóa)";
                if (i == 41)
                    btn.Text = "Rừng quốc gia Pù Mát, Con Cuông (Nghệ An)";
                if (i == 42)
                    btn.Text = "Biển Thiên Cầm (Hà Tĩnh)";
                if (i == 43)
                    btn.Text = "Thung Nham - Thung Chim (Ninh Bình)";
                if (i == 44)
                    btn.Text = "Đèo Hải Vân – Đầm Lập An – Vườn Quốc Gia Bạch Mã (Thừa Thiên Huế)";
                if (i == 45)
                    btn.Text = "Quốc lộ 49B: 5 đầm, 3 biển, 1 động, 1 phá (Huế)";
                if (i == 46)
                    btn.Text = "Đèo A Co – Thác A Nor (Huế)";
                if (i == 47)
                    btn.Text = "Hồ Chí Minh - đèo Pêke (Huế)";
                if (i == 48)
                    btn.Text = "Khe Tre - Thác Mơ";
                if (i == 49)
                    btn.Text = "Biển An Bàng";
                if (i == 50)
                    btn.Text = "Cù Lao Chàm";
                if (i == 51)
                    btn.Text = "Đà Lạt (Lâm Đồng)";
                if (i == 52)
                    btn.Text = "Nam Du (Kiên Giang)";
                if (i == 53)
                    btn.Text = "Đường ven biển Ninh Thuận";
                if (i == 54)
                    btn.Text = "Bảo Lộc - Đà Lạt - Dran (Đà Lạt)";
                if (i == 55)
                    btn.Text = "Bình Ba";
                if (i == 56)
                    btn.Text = "Bình Lập";
                if (i == 57)
                    btn.Text = "Bình Hưng";
                if (i == 58)
                    btn.Text = "Biển Bình Tiên – Nàng công chúa ngủ quên";
                if (i == 59)
                    btn.Text = "Phú Quốc (Kiên Giang)";
                if (i == 60)
                    btn.Text = "Vũng Tàu";
                if (i == 61)
                    btn.Text = "Long An";
                if (i == 62)
                    btn.Text = "Tiền Giang";
                if (i == 63)
                    btn.Text = "Bến Tre";
                if (i == 64)
                    btn.Text = "Trà Vinh";
                if (i == 65)
                    btn.Text = "Sóc Trăng";
                if (i == 66)
                    btn.Text = "Cần Thơ";
                if (i == 67)
                    btn.Text = "Vĩnh Long";
                if (i == 68)
                    btn.Text = "Đồng Tháp";



                btn.AutoSize = true;
                btn.Location = new Point(10, panel1.Controls.Count * 25);
                panel1.Controls.Add(btn);
            }
        }

        private void Btn_Click38(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Vịnh Vũng Rô");
            form.Show();
        }
        private void Btn_Click37(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Vực Phun");
            form.Show();
        }
        private void Btn_Click36(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Suối Cá Thần Cẩm Lương");
            form.Show();
        }
        private void Btn_Click35(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Vườn quốc gia Pù Mát");
            form.Show();
        }
        private void Btn_Click34(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Động Thiên Đường");
            form.Show();
        }
        private void Btn_Click33(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Đảo Phú Quý");
            form.Show();
        }
        private void Btn_Click32(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Biển Bình Tiên");
            form.Show();
        }
        private void Btn_Click31(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Cù Lao Xanh");
            form.Show();
        }
        private void Btn_Click30(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Đảo Lý Sơn");
            form.Show();
        }
        private void Btn_Click29(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Bà Nà");
            form.Show();
        }
        private void Btn_Click28(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Pù Luông");
            form.Show();
        }
        private void Btn_Click27(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Sìn Hồ");
            form.Show();
        }
        private void Btn_Click26(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Y Tý");
            form.Show();
        }
        private void Btn_Click25(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Háng Đồng");
            form.Show();
        }
        private void Btn_Click24(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Núi Muối");
            form.Show();
        }
        private void Btn_Click23(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Bạch Mộc Lương Tử");
            form.Show();
        }
        private void Btn_Click22(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Tà Xùa");
            form.Show();
        }
        private void Btn_Click21(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Đỉnh Lảo Thẩn");
            form.Show();
        }
        private void Btn_Click20(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Côn Sơn Kiếp Bạc");
            form.Show();
        }
        private void Btn_Click19(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Hồ Quan Sơn");
            form.Show();
        }
        private void Btn_Click18(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Hồ Núi Cốc");
            form.Show();
        }
        private void Btn_Click17(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Bình Liêu");
            form.Show();
        }
        private void Btn_Click16(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Bãi Dài");
            form.Show();
        }
        private void Btn_Click15(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Tây Yên Tử");
            form.Show();
        }
        private void Btn_Click14(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Vịnh Lan Hạ");
            form.Show();
        }
        private void Btn_Click13(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Hồ Thung Nai");
            form.Show();
        }
        private void Btn_Click12(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Vườn quốc gia Ba Vì");
            form.Show();
        }
        private void Btn_Click11(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Thác Bản Giốc");
            form.Show();
        }
        
        private void Btn_Click10(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Đồng Cao");
            form.Show();
        }
        private void Btn_Click9(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Vườn Quốc gia Xuân Sơn");
            form.Show();
        }
        private void Btn_Click8(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Hồ Pa Khoang");
            form.Show();
        }
        private void Btn_Click7(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("SaPa");
            form.Show();
        }
        private void Btn_Click6(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Mù Cang Chải");
            form.Show();
        }
       

        private void Btn_Click5(object sender, EventArgs e)
        {
            info form = new info();
            form.Sender("Háng Tề Chơ");
            form.Show();
            
            
        }
        private void Btn_Click4(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Hàm Lợn");
            form.Show();

        }
        private void Btn_Click3(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Tam Đảo");
            form.Show();
            
        }
        private void Btn_Click2(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Mai Châu");
            form.Show();            

        }
        private void Btn_Click1(object sender, EventArgs e)
        {
            //throw new NotImplementedException();

            info form = new info();
            form.Sender("Mộc Châu");
            //form.SenderP = TravelPlannerApp.Properties.Resources.Mộc_Châu_400x255;
            form.Show();
           
        }

      
    }
}

