using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Assignment_1
{
    internal class Fraction
    {
        //Properties (with shorthand for getter and setter)
        public int TuSo { get; set; }
        public int MauSo { get; set; }


        //Constructors:
        public Fraction() { }

        public Fraction(int tuSo, int mauSo)
        {
            TuSo = tuSo;
            MauSo = mauSo;
        }

        //Other methods
        public void InPhanSo()
        {
            if (TuSo * MauSo <= 0)
            {
                Console.WriteLine("-" + Math.Abs(TuSo) + "/" + Math.Abs(MauSo));
            }
            else
            {
                Console.WriteLine(Math.Abs(TuSo) + "/" + Math.Abs(MauSo));
            }
        }

        public void RutGon()
        {
            int ucln = 1;
            for (int i = Math.Abs(TuSo); i > 1; i--)
            {
                if (TuSo % i == 0 && MauSo % i == 0)
                {
                    ucln = i;
                    break;
                }
            }
            TuSo = TuSo / ucln;
            MauSo = MauSo / ucln;
        }
        
        public void NghichDao()
        {
            int temp = TuSo;
            if (temp != 0)
            {
                TuSo = MauSo;
                MauSo= temp;
            }
        }

        public Fraction add(Fraction f)
        {
            Fraction result = new Fraction();
            result.MauSo = this.MauSo * f.MauSo;
            result.TuSo = this.TuSo * f.MauSo + this.MauSo*f.TuSo;
            result.RutGon();
            return result;
        }

        public Fraction subtract(Fraction f)
        {
            int ts = this.TuSo * f.MauSo - this.MauSo * f.TuSo;
            int ms = this.MauSo * f.MauSo;
            Fraction result = new Fraction(ts, ms);
            return result;
        }

        public Fraction multiply(Fraction f)
        {
            return new Fraction(this.TuSo * f.TuSo, this.MauSo * f.MauSo);
        }

        public Fraction divide(Fraction f)
        {
            f.NghichDao();
            return this.multiply(f);
        }

    }
}
