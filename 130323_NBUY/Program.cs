using System;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Channels;

namespace _130323_NBUY
{
    internal class Program
    {
        static void Main(string[] args)

        {
            #region okul-ogretmen sınıf miraslanma örnek
            /*  ogretmen ogretmen1 = new ogretmen();
       ogretmen1.ogretmenAd = "Zeliha Tok";
       ogretmen1.ogrenciAd = "Veli Falez";

       okul okul1 = new okul();
       okul1.okulAd = "Zekiler Koleji";

       mudur mudur1 = new mudur();
       mudur1.mudurAd = "Hasan Borulu";

       Console.WriteLine(okul1.okulAd + "'nde");
       Console.WriteLine(mudur1.mudurAd + " " + "müdürlüğünde");
       Console.WriteLine(ogretmen1.ogretmenAd + " " + "öğretmenin öğrencisi" + " " + ogretmen1.ogrenciAd + "'dir.");*/

            //  mudur.maas(399); 
            #endregion

            Console.WriteLine("ad gir");
            string _ad = Console.ReadLine();
            Console.WriteLine("soyad gir");
            string _soyad = Console.ReadLine();
            Console.WriteLine("yas gir-");
            int _yas = int.Parse(Console.ReadLine());

            veriGir v1;
            v1 = new veriGir(_ad, _soyad, _yas);
        }
        internal class veriGir
        {
            public string ad { get; set; }
            public string soyad { get; set; }
            public int yas { get; set; }
            public veriGir(string _ad, string _soyad, int _yas)
            {
                Console.WriteLine("ad" + " " + _ad);
                Console.WriteLine("soyad" + " " + _soyad);
                Console.WriteLine("yas" + " " + _yas);
            }
        }

    }
}
