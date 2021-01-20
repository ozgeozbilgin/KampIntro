using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            string adi = "Engin";
            int yas = 36;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "engin demiroğ";
            kurs1.IzlenmeOrani = "68";

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "java";
            kurs2.Egitmen = " kerem varış";
            kurs2.IzlenmeOrani = "64";

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "python";
            kurs3.Egitmen = "berkay bilgin";
            kurs3.IzlenmeOrani = "80";

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "c++";
            kurs4.Egitmen = "murar kurtboğan";
            kurs4.IzlenmeOrani = "100";

            // Console.WriteLine(kurs1.KursAdi + ":" + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] { kurs1,kurs2,kurs3,kurs4};

            foreach (var kurs in kurslar)
            {

                Console.WriteLine(kurs.KursAdi + ":" + kurs.Egitmen);

                //Console.WriteLine(kurs.KursAdi);
            }

            Console.ReadLine();
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public string IzlenmeOrani { get; set; }


    }
}
