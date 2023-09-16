using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp1_BaiTap1
{
    internal class SinhVienUD : SinhVien
    {
        private int Kihoc;

        public SinhVienUD(int kihoc, string maSV, string ten, int namSinh, double diem) :  base(maSV, ten, namSinh, diem)
        {
            Kihoc = kihoc;
        }
        public SinhVienUD()
        {
            
        }
        public override void inThongTin()
        {
            Console.WriteLine($"MaSV: {this.MaSVa} \t Ten: {Tena} \t NamSinh: {NamSinhA} \t Diem: {DiemA} \t KyHoc: {Kihoc}");
        }
    }
}
