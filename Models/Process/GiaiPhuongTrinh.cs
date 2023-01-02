using Microsoft.AspNetCore.Mvc;
using TranDucHung.Models;
namespace TranDucHung.Models.Process
{
    public class GiaiPhuongTrinh
    {
        //xay dung cac phuong thuc
        // public string GiaiPhuongTrinhBacNhat(double heSoA, double heSoB)
        // {
        //     //khai bao 1 bien  de chua du lieu
        //     string thongBao = "";
        //     //khai bao 1 bien so de chua gia tri
        //     double x;
        //     //Giai phuong trinh
        //     if (heSoA == 0)
        //     {
        //         if (heSoB == 0)
        //         {
        //             thongBao = "Phuong trinh co vo so nghiem.";
        //         }
        //         else
        //         {
        //             thongBao = "Phuong trinh vo nghiem";
        //         }

        //     }
        //     else
        //     {
        //         //tinh nghiem cua phuong trinh
        //         x = -heSoB / heSoA;
        //         thongBao = " nghiem x= " + x;
        //     }
        //     //tra ve du lieu
        //     return thongBao;
        // }
        public string GiaiPhuongTrinhBacNhat(double hesoA, double hesoB)

        {

            string thongBao = "";

            double x;

            if (hesoA == 0)

            {

                if (hesoB == 0)

                {

                    thongBao = "Phương trình có vô số nghiệm";

                }

                else

                {

                    thongBao = "phuong trinh vo nghiem";

                }

            }

            else

            {

                x = -hesoB / hesoA;

                thongBao = "Phương trình có nghiệm là:" + x;

            }



            return thongBao;

        }


        //giải phương trình b2
        public string GiaiPhuongTrinhBacHai(double a, double b, double c)
        {
            string thongBao = "";
            double x1;
            double x2;
            double delta;
            if (a == 0)
            {
                thongBao = GiaiPhuongTrinhBacNhat(b, c);
                if (b == 0)
                {
                    //nếu b = 0 và c = 0 thì phương trình vô số nghiệm
                    if (c == 0)
                    {
                        thongBao = " Phuong trinh co vo so nghiem.";
                    }
                    //nếu b = 0 và c != 0 thì phương trình vô nghiệm
                    else
                    {
                        thongBao = "Phuong trinh vo nghiem.";
                    }
                }
                else
                {
                    x1 = (double)-c / b;
                    //Sử dụng phương thứ Math.Round() để làm tròn kết quả lên 2 số thập phân
                    thongBao = "Phuong trinh co nghiem duy nhat x = {0}" + (Math.Round(x1, 2));
                }
            }
            //nếu a != 0 thì ta bắt đầu giải phương trình bậc hai
            else
            {
                //tính delta
                delta = Math.Pow(b, 2) - 4 * a * c;
                //kiểm tra nếu delta < 0 thì phương trình vô nghiệm
                if (delta < 0)
                {
                    thongBao = "Phuong trinh vo nghiem.";
                }
                //nếu delta = 0 thì phương trình có hai nghiệm kép
                else if (delta == 0)
                {
                    x1 = x2 = -b / (2 * a);
                    thongBao = "\n Phuong trinh co nghiem kep x1 = x2 = " + x1;
                }
                //nếu delta > 0 thì phuong trình có hai nghiệm phân biệt
                else
                {
                    x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    thongBao =
                    "Phương trình có nghiệm X1=" + x1 + "" + "và" + "" + "X2=" + x2;
                }
            }

            return thongBao;

        }
        public string bth(double ll, double mm)
        {
            string thongBao = "";
            double x;
            x = ll + mm;
            thongBao = "Tổng" + x;
            return thongBao;
        }


    }
}