using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Kitap Sayfa:179-180

namespace MetotKullanimi6Diziler2
{
    class Program
    {
        static void DiziYaz(Array parametredizi, int Bicim) //int[] parametredizi --> Array parametredizi 
        {
            if (Bicim == 0)
            {
                foreach (Object i in parametredizi) //Buradaki int değerini object ile değiştirirsek bu metodu daha da genişleterek bütün dizi tiplerini...
                    Console.WriteLine(i.ToString());
            }
            else if (Bicim == 1)
                foreach (Object i in parametredizi)
                    Console.Write(i.ToString());
            else
                Console.WriteLine("0 veya 1 harici başka bir tuşa bastınız...");

              Console.ReadKey();
        }

        static void Main(string[] args)
        {
            int secim;
            int[] dizi = { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine("Diziyi yanyana yazdırmak istiyorsanız 1' e alt alta yazdırmak istiyorsanız 0' a basınız...");
            secim = Convert.ToInt32(Console.ReadLine());
            DiziYaz(dizi,secim);
        }
    }
}
