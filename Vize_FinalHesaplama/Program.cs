using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vize_FinalHesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Satır sayısını giriniz:");
            byte satir = byte.Parse(Console.ReadLine());
            double vize;
            double final;
            double ortalama;

            string[,] ogrenciler = new string[satir + 1, 6];
            ogrenciler[0, 0] = "Ad";
            ogrenciler[0, 1] = "Soyad";
            ogrenciler[0, 2] = "Vize";
            ogrenciler[0, 3] = "Final";
            ogrenciler[0, 4] = "Ortalama";
            ogrenciler[0, 5] = "HarfNotu";

            for (int i = 1; i < ogrenciler.GetLength(1); i++)
            {
               
                        
                Console.WriteLine("Öğrenci Adını Giriniz:");
                ogrenciler[i, 0] = Console.ReadLine();
                           
                Console.WriteLine("Öğrenci Soyadını Giriniz:");
                ogrenciler[i, 1] = Console.ReadLine();
                           
                      
                Console.WriteLine("Vize Notunu Giriniz:");
                ogrenciler[i, 2] = Console.ReadLine();
                vize = Convert.ToDouble(Console.ReadLine());
                         
                    
                Console.WriteLine("Final Notunu Giriniz:");
                ogrenciler[i, 3] = Console.ReadLine();
                final = Convert.ToDouble(Console.ReadLine());
                          
                       
                Console.WriteLine("Ortalama");
                ortalama = vize * 0.4 + final * 0.6;
                Console.WriteLine("{0}", ortalama);
                ogrenciler[i, 4] = Console.ReadLine();


                if (ortalama <= 100 && ortalama >= 85)
                {
                    Console.WriteLine("AA");
                    ogrenciler[i, 5] = Console.ReadLine();
                }
                else if (ortalama < 85 && ortalama >= 70)
                {
                    Console.WriteLine("BA");
                    ogrenciler[i, 5] = Console.ReadLine();
                }
                else if (ortalama < 70 && ortalama >= 60)
                {
                    Console.WriteLine("BB");
                    ogrenciler[i, 5] = Console.ReadLine();
                }
                else if (ortalama < 60 && ortalama >= 50)
                {
                    Console.WriteLine("CB");
                    ogrenciler[i, 5] = Console.ReadLine();
                }
                else if (ortalama < 50 && ortalama >= 40)
                {
                    Console.WriteLine("CC");
                    ogrenciler[i, 5] = Console.ReadLine();
                }
                else if (ortalama < 40 && ortalama >= 30)
                {
                    Console.WriteLine("CD");
                    ogrenciler[i, 5] = Console.ReadLine();
                }
                else if (ortalama < 30 && ortalama >= 20)
                {
                    Console.WriteLine("DD");
                    ogrenciler[i, 5] = Console.ReadLine();
                }
                else if (ortalama < 20 && ortalama >= 0)
                {
                    Console.WriteLine("FF Kaldınız!");
                    ogrenciler[i, 5] = Console.ReadLine();
                }
                           
            }
                    
                
           for (int i = 0; i < ogrenciler.GetLength(0); i++)
            {
                for (int j = 0; j < ogrenciler.GetLength(1); j++)
                {
                    Console.WriteLine(ogrenciler[i, j] + "\t");
                }
                Console.WriteLine();

            }

            Console.ReadKey();

        }
    }
}
