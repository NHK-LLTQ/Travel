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
                    btn.Click += Btn_Click;
                }
                if (i == 2)
                {
                    btn.Text = "Mai Châu ( Hòa Bình)";
                    btn.Click += Btn_Click1;
                }
                if (i == 3)
                {
                    btn.Text = "Tam Đảo (Vĩnh Phúc)";
                    btn.Click += Btn_Click2;
                }
                if (i == 4)
                {
                    btn.Text = "Hàm Lợn (Hà Nội)";
                    btn.Click += Btn_Click3;
                }
                if (i == 5)
                {
                    btn.Text = "Háng Tề Chơ(Yên Bái)";
                    btn.Click += Btn_Click4;
                }
                if (i == 6)
                    btn.Text = "Mù Cang Chải (Yên Bái)";
                if (i == 7)
                    btn.Text = "Sapa (Lào Cai)";
                if (i == 8)
                    btn.Text = "Hồ Pa Khoang (Điện Biên)";
                if (i == 9)
                    btn.Text = "Vườn Quốc gia Xuân Sơn (Phú Thọ)";
                if (i == 10)
                    btn.Text = "Đồng Cao (Bắc Giang)";
                if (i == 11)
                    btn.Text = "Thác Bản Giốc (Cao Bằng)";
                if (i == 12)
                    btn.Text = "Vườn quốc gia Ba Vì (Hà Nội)";
                if (i == 13)
                    btn.Text = "Hồ Thung Nai (Hòa Bình)";
                if (i == 14)
                    btn.Text = "Vịnh Lan Hạ (Hải Phòng)";
                if (i == 15)
                    btn.Text = "Trekking Tây Yên Tử (Quảng Ninh)";
                if (i == 16)
                    btn.Text = "Bãi Dài (Quảng Ninh)";
                if (i == 17)
                    btn.Text = "Bình Liêu (Quảng Ninh)";
                if (i == 18)
                    btn.Text = "Hồ Núi Cốc (Thái Nguyên)";
                if (i == 19)
                    btn.Text = "Hồ Quan Sơn (Hà Nội)";
                if (i == 20)
                    btn.Text = "Côn Sơn Kiếp Bạc (Hải Dương)";
                if (i == 21)
                    btn.Text = "Đỉnh Lảo Thẩn (Lào Cai)";
                if (i == 22)
                    btn.Text = "Tà Xùa (Sơn La)";
                if (i == 23)
                    btn.Text = "Bạch Mộc Lương Tử (Lào Cai)";
                if (i == 24)
                    btn.Text = "Núi Muối (Lào Cai)";
                if (i == 25)
                    btn.Text = "Háng Đồng (Sơn La)";
                if (i == 26)
                    btn.Text = "Y Tý (Lào Cai)";
                if (i == 27)
                    btn.Text = "Sìn Hồ (Lai Châu)";
                if (i == 28)
                    btn.Text = "Pù Luông (Thanh Hóa)";
                if (i == 29)
                    btn.Text = "Bà Nà (Đà Nẵng)";
                if (i == 30)
                    btn.Text = "Đảo Lý Sơn (Quảng Ngãi)";
                if (i == 31)
                    btn.Text = "Cù Lao Xanh (Bình Định)";

                if (i == 32)
                    btn.Text = "Biển Bình Tiên (Ninh Thuận)";

                if (i == 33)
                    btn.Text = "Đảo Phú Quý (Bình Thuận)";

                if (i == 34)
                    btn.Text = "Động Thiên Đường (Quảng Bình)";

                if (i == 35)
                    btn.Text = "Vườn quốc gia Pù Mát (Nghệ An)";
                if (i == 36)
                    btn.Text = "Suối Cá Thần Cẩm Lương (Thanh Hóa)";

                if (i == 37)
                    btn.Text = "Vực Phun (Phú Yên)";

                if (i == 38)
                    btn.Text = "Vịnh Vũng Rô (Phú Yên)";

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

        private void Btn_Click4(object sender, EventArgs e)
        {
            info form = new info();
            form.Sender("Háng Tề Chơ");
            form.Show();
            
            
        }
        private void Btn_Click3(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Hàm Lợn");
            form.Show();

        }
        private void Btn_Click2(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Tam Đảo");
            form.Show();
            
        }
        private void Btn_Click1(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            info form = new info();
            form.Sender("Mai Châu");
            form.Show();
            

        }
        protected void Btn_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();

            info form = new info();
            form.Sender("Mộc Châu");
            form.Show();
           
        }

      
    }
}
