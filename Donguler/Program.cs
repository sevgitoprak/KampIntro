﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım geliştirici yetiştirme kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";

            //array-dizi

            string[] kurslar = new string[] { "Yazılım geliştirici yetiştirme kampı", 
                "Programlamaya başlangıç için temel kurs",
                "Java","C#"};

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For bitti");
           

            foreach (string kurs in kurslar)//kurs yerine istediğini yazabilirsin,takma isim verdim
            {
                //dizi temelli yapıları tek tek dönmeye yarar.
                Console.WriteLine(kurs);//takma ismi burda yazıyorum
            }
            Console.ReadLine();


            
        }
    }
}
