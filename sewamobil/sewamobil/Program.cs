using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sewamobil
{
    class Program
    {
        private static string d;

        static void hitunglagi(int x, int y)
        {
            hitungsewamobil objek = new hitungsewamobil(x, y);
        }

        static void Main(string[] args)
        {
            string ulang;
            ulang = "yes";
            while (ulang == "yes")
            {
                string a;
                int kode;
                string b;
                int lama;
                string d;
                konstruktor two = new konstruktor("Oryza Satifha Andesti", "21120117130050");
                Console.WriteLine(two.intro());

                konstruktor three = new konstruktor("Salma Asri Ardiningrum", "21120117130036");
                Console.WriteLine(three.intro());
                Console.WriteLine("               SIFT 4                 ");
                Console.WriteLine("======================================");
                Console.WriteLine("======  Program Penyewaan Mobil ======");
                Console.WriteLine("======================================");
                Console.WriteLine(" ");
                konstruktor one = new konstruktor();
                Console.Write("Masukkan Kode Mobil [1-3] : ");
                a = Console.ReadLine();
                int.TryParse(a, out kode);

                switch (kode)
                {
                    case (1):
                        int satu = 450000;
                        Console.Write("Masukkan Lama Sewa [/hari] : ");
                        b = Console.ReadLine();
                        int.TryParse(b, out lama);
                        hitunglagi(satu, lama);
                        break;
                    case (2):
                        int dua = 500000;
                        Console.Write("Masukkan Lama Sewa [/hari] : ");
                        b = Console.ReadLine();
                        int.TryParse(b, out lama);
                        hitunglagi(dua, lama);
                        break;
                    case (3):
                        int tiga = 650000; //kugantiyaharganya
                        Console.Write("Masukkan Lama Sewa [/hari] : ");
                        b = Console.ReadLine();
                        int.TryParse(b, out lama);
                        hitunglagi(tiga, lama);
                        break;
                    default:
                        Console.WriteLine("inputan salah");
                        break;
                }
                Console.Write("kembali ke menu utama? [yes/no] : ");
                ulang = Console.ReadLine();
            }
            Console.ReadKey();
        }
    }
}
