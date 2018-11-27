using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merkkijonot_ohj_jatko_pv03_esim01
{
    class Program
    {/// <summary>
    ///  Tämä on XML kommentointilohko, joka voidaan kerätä erilliseen XML-tiedostoon
    ///  On olemassa dokumentointityövälineitä, jotka osaavat lukea tämän ja muodostaa dokumentaation
    /// </summary>
    /// <param name="args"></param>


        static void Main(string[] args)
        {
            //throw new ApplicationException("Pöö");  (Ctrl+F5 eli Start without debugging = 
            // sovellus ajetaan kuin se ajettaisiin käyttiksen kautta eli suoritetaan exe-tiedosto.

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
