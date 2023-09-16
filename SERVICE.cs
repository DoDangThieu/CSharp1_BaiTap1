using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CSharp1_BaiTap1
{
    internal class SERVICE
    {
        List<SinhVien> SV = new List<SinhVien>();
        internal void nhap()
        {
            do
            {
                SinhVien sv = new SinhVien();
                sv.nhap();
                SV.Add(sv);
                Console.Write("Bạn có muốn nhập nữa không?(c/k)");
                string traLoi = Console.ReadLine().ToUpper();
                if (traLoi == "K")
                {
                    break;
                }
            } while (true);
        }

        internal void xuat()
        {
            foreach (SinhVien sv in SV)
            {
                sv.inThongTin();
            }
        }
        internal void XuatVe()
        {
            Console.WriteLine("Xuất danh sách các SV được tặng vé VIP HappyBee: ");
            foreach (SinhVien sv in SV)
            {
                if (sv.DiemA>=8)
                {
                    sv.inThongTin();
                }
            }
        }
        internal void Xoa()
        {
            Console.WriteLine("Xóa sinh viên không được tham gia Happy Bee và Tuổi >25: ");

            for (int i = SV.Count - 1; i >= 0; i--)
            {
                SinhVien currentSv = SV[i];
                int tuoi = DateTime.Now.Year - currentSv.NamSinhA;

                if (currentSv.DiemA < 8 && tuoi > 25)
                {
                    SV.RemoveAt(i);
                }
            }
        }


        internal void Kethua()
        {
            Console.WriteLine("Kế thừa");
            Console.Write("Nhập mã số sinh viên: ");
            string MaSV = Console.ReadLine();
            Console.Write("Nhập tên sinh viên: ");
            string Ten = Console.ReadLine();
            Console.Write("Nhập năm sinh sinh viên: ");
            int NamSinh = int.Parse(Console.ReadLine());
            Console.Write("Nhập điểm sinh viên: ");
            double Diem = double.Parse(Console.ReadLine());
            Console.Write("Nhập kỳ học sinh viên: ");
            int KyHoc = int.Parse(Console.ReadLine());
            SinhVienUD SVUD = new SinhVienUD(KyHoc,MaSV, Ten, NamSinh, Diem);
            SVUD.inThongTin();
        }
    }
}
