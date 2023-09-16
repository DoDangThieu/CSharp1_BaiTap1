using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp1_BaiTap1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            SERVICE SV = new SERVICE();
            int chon;
            do
            {
                Console.WriteLine("+++==========================Menu================================+++");
                Console.WriteLine("1.Nhập danh sách sinh viên");
                Console.WriteLine("2.Xuất danh sách sinh viên");
                Console.WriteLine("3.Xuất danh sách các SV được tặng vé VIP HappyBee");
                Console.WriteLine("4.Xóa sinh viên không được tham gia Happy Bee và Tuổi >25");
                Console.WriteLine("5.Kế thừa");
                Console.WriteLine("0.Thoát");
                Console.WriteLine("+++==========================Menu================================+++");
                Console.Write("Mời chọn chức năng chương trình: ");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        Console.WriteLine("Chức năng 1");
                        SV.nhap();
                        break;
                    case 2:
                        Console.WriteLine("Chức năng 2");
                        SV.xuat();
                        break;
                    case 3:
                        Console.WriteLine("Chức năng 3");
                        SV.XuatVe();
                        break;
                    case 4:
                        Console.WriteLine("Chức năng 4");
                        SV.Xoa();
                        Console.WriteLine();
                        break;
                    case 5:
                        Console.WriteLine("Chức năng 5");
                        SV.Kethua();
                        Console.WriteLine();
                        break;
                    case 0:
                        Console.WriteLine("Chức năng thoát");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Chức năng bạn chọn không có mời chọn lại");
                        break;
                }
            } while (chon != 0);
            Console.ReadKey();
        }
    }
}
