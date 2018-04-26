using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sewamobil
{
    class konstruktor
    {

        public String nama;
        public string id;

        public konstruktor()
        {
            Console.WriteLine("1. Toyota Fortuner (Rp 550.000/hari)");
            Console.WriteLine("2. Honda CRV (Rp 400.000/hari)");
            Console.WriteLine("3. Mitsubisi Pajero (Rp 650.000/hari)");
        }
        public konstruktor(String nama, String id) //Constructor dengan parameter//
        {
            this.nama = nama;
            this.id = id;
        }
        public String intro() //Method non parameter//
        {
            return "Nama saya: " + nama + " / NIM saya:" + id;
        }
    }
}
