using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tip_Donusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "2";
            string str2 = "3";
            string strSonuc = str1 + str2;
            int sayi1 = Convert.ToInt32(str1);
            int sayi2 = Convert.ToInt32(str2);
            int intSonuc = sayi1 + sayi2;
            Console.WriteLine("Metinsel işlem sonucu: " + strSonuc + "\nSayısal işlem sonucu: " + intSonuc);
            int sayi = Convert.ToInt32("5"); // String'ten Int'e dönüştürür.
            string str = Convert.ToString(sayi1); // String'e dönüştürür.
            bool durum1 = Convert.ToBoolean("true");
            //bool durum2 = Convert.ToBoolean("doğru"); Bu yanlış convet işlemidir.
            bool durum2 = Convert.ToBoolean(0); // Sayısal 1 ve 0 bool değerine dönüşebilir.
            Console.WriteLine(durum2);
            char chr = Convert.ToChar(215); // Sayısal değeri chara dönüştürür. ASCII kod karşılığı yazılır.
            Console.WriteLine(chr);
            //int sayi3 = Convert.ToInt32("54AA"); Sayısal değildir metinseldir. Dönüştüremez.
            byte byt = Convert.ToByte("12");
            short shrt = Convert.ToInt16("12");
            long lng = Convert.ToInt64("12");
            double dbl = Convert.ToDouble("1.5");
            float flt = Convert.ToSingle("122");
            decimal dcml = Convert.ToDecimal("133");
            Console.ReadKey();
        }
    }
}
/* + operatörü; sayısal ifadelerde toplama işlemi, metinsel ifadelerde ise birleşme işlemi yapar.
   ToInt16 => short veri tipini dönüştürür.
   ToInt32 => int veri tipini dönüştürür.
   ToInt64 => long veri tipini dönüştürür.
   0'ın boolean olarak karşılığı false'dir. 1'in true'dir.
*/
