using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;//sayi1 in değeri 10
            int sayi2 = 30;
            sayi1 = sayi2;//sayi1 in değeri sayi2 nin değeri
            sayi2 = 65;
            //sayi1 ?? 30

            int[] sayilar1 = new int[] { 10, 20, 30 };//int[] sayilar1 e kadar sayilar 1 adında stackte yer ayarladım
            //newlediğim anda 10, 20, 30 heapte yer alıyo.
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2; //sayilar1 in heapteki refransını değiştirdim.{ 100, 200, 300 } bu oldu
            //tam o anda garbage collector { 10, 20, 30 } u temizleyecek
            sayilar2[0] = 999;
            //sayilar1[0] ? 999

            /*int,decimal,float,double,bool----->değer tip
             * array,class,interface------->referans tip */

            //STACK-HEAP
            //Değer tipler Stack'te
            //Referans tipler Heap'te

        }
    }
}
