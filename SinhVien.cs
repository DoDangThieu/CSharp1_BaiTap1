using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace CSharp1_BaiTap1
{
    internal class SinhVien
    {
        private string MaSV;
        private string Ten;
        private int NamSinh;
        private double Diem;

        public SinhVien()
        {
            
        }
        public SinhVien(string maSV, string ten, int namSinh, double diem)
        {
            MaSV = maSV;
            Ten = ten;
            NamSinh = namSinh;
            Diem = diem;
        }
        public string MaSVa
        {
            get { return MaSV; }
            set { MaSV = value; }
        }
        public string Tena
        {
            get { return Ten; }
            set { Ten = value; }
        }
        public double DiemA
        {
            get { return Diem; }
            set
            {
                if (value >= 0 && value <= 10)
                {
                    Diem = value;
                }
                else
                {
                    Console.WriteLine("Điểm không hợp lệ");
                }

            }
        }
        public int NamSinhA
        {
            get { return NamSinh; }
            set
            {
                if (value < DateTime.Now.Year)
                {
                    NamSinh = value;
                }
                else
                {
                    Console.WriteLine("Năm sinh không hợp lệ");
                }

            }
        }
        public virtual void inThongTin()
        {
            Console.WriteLine($"MaSV: {MaSV} \t Ten: {Ten} \t NamSinh: {NamSinh} \t Diem: {Diem}");
        }
        public void nhap()
        {
            Console.Write("Nhập mã số sinh viên: ");
            this.MaSV = Console.ReadLine();
            Console.Write("Nhập tên sinh viên: ");
            this.Ten = Console.ReadLine();
            Console.Write("Nhập năm sinh sinh viên: ");
            this.NamSinh = int.Parse(Console.ReadLine());
            Console.Write("Nhập điểm sinh viên: ");
            this.Diem = double.Parse(Console.ReadLine());

        }
    }
}
