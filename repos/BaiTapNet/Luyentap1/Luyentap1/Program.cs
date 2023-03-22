using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luyentap1
{
    class SinhVien
    {
        protected bool gioiTinh=true;
        protected string hoTen;
        protected DateTime ngaySinh;
        public SinhVien(string name, string sex, DateTime dob) { }

        public SinhVien(string name, string sex, string dob)
        {
            this.hoTen = name;
            sex = sex.Trim().ToUpper();
            this.gioiTinh = (sex == "NAM" || sex == "MALE" || sex == "1");
            try
            {
                this.ngaySinh = DateTime.Parse(dob);
            }
            catch(Exception ex)
            {
                this.ngaySinh = DateTime.Today;
            }
        }
        public virtual double dtb()
        {
            return -10;
        }
        public override string ToString()
        {
            return string.Format("{0,30} {1:0.00}", this.hoTen, this.dtb());
        }
    }

    class SinhVienVan:SinhVien
    {
        double coDien;
        double hienDai;

        public override double dtb()
        {
            return (coDien + hienDai) / 2;
        }
        public SinhVienVan(string name, string sex, string dob, double classic, double modern)
            :base(name, sex, dob)
        {
            this.coDien = classic;
            this.hienDai = modern;
        }
    }
    class SinhVienCNTT:SinhVien
    {
        double csharp;
        double pascal;
        double sql;

        public override double dtb()
        {
            return (csharp + pascal + sql) / 3;
        }
        public SinhVienCNTT(string name, string sex, string dob, double csharp, double pascal, double sql)
            :base(name, sex, dob)
        {
            this.csharp = csharp;
            this.pascal = pascal;
            this.sql = sql;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("So luong sinh vien: ");
            int n = int.Parse(Console.ReadLine());

            SinhVien[] sv = new SinhVien[n];
            for (int i=0; i<n; i++)
            {
                Console.WriteLine("Nhap sinh viên thứ {0} " + (i + 1));
                Console.Write("\tHo ten: ");
                string hoTen = Console.ReadLine();
                Console.Write("\tGioi tinh: [1]Nam [0]Nu ");
                string gioiTinh = Console.ReadLine();
                Console.Write("Ngay Sinh: ");
                string ngaySinh = Console.ReadLine();
                Console.Write("Chuyen nganh cua sinh vien [1]Van [2]CNTT [any key]Vat ly ");

                char k = char.Parse(Console.ReadLine());
                switch(k)
                {
                    case '1':
                        #region Nhap diem cho sinh vien van
                        double coDien, hienDai;
                        Console.Write("\tDiem van co dien: ");
                        coDien = double.Parse(Console.ReadLine());
                        Console.Write("\tDiem van hien dai: ");
                        hienDai = double.Parse(Console.ReadLine());

                        sv[i] = new SinhVienVan(hoTen, gioiTinh, ngaySinh, coDien, hienDai);
                        break;
                    #endregion
                    case '2':
                        #region Nhap diem cho sinh cntt
                        double csharp, pascal, sql;
                        Console.Write("\tDiem csharp: ");
                        csharp = double.Parse(Console.ReadLine());
                        Console.Write("\tDiem pascal: ");
                        pascal = double.Parse(Console.ReadLine());
                        Console.Write("\tDiem sql: ");
                        sql = double.Parse(Console.ReadLine());

                        sv[i] = new SinhVienCNTT(hoTen, gioiTinh, ngaySinh, csharp, pascal, sql);
                        break;
                        #endregion

                }
            }
            for (int i = 0; i < n; i++)
                Console.WriteLine("{0,3}, {1}", i + 1, sv[i]);
        }
    }
}
