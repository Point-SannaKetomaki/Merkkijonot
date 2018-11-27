using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merkkijonot_ohj_jatko_pv03_esim01
{
    class Program
    {
        static void Main(string[] args)
        {
            //huono tapa, raskas roskien keräyksen mielessä.
            //string s = "ABC";
            //for (int i = 0; i < 100000; i++)
            //{
            //    s = s + "!";
            //}
            //Console.WriteLine(s);
            //Console.ReadLine();


            //parempi tapa, ohjelma ajaa käskyn huomattavasti nopeammin.
            string s = "";
            StringBuilder sb = new StringBuilder("ABC");
            for (int i = 0; i < 100000; i++)
            {
                sb.Append("!");
            }
            Console.WriteLine(s = sb.ToString());
            Console.ReadLine();
        }
    }
}
