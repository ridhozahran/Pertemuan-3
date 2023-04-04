using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mobil
{
    class Program
    {
        static void Main(String[] args)
        {

            Mobil mobil = new Mobil();

            Console.WriteLine();

            mobil.Warna         = "Putih";
            mobil.Merk          = "Mustang GT";
            mobil.Model         = "Sport";
            mobil.tahunKeluar   = "2022";
            mobil.jumlahPintu   = "2";
            mobil.Kecepatan     = 1500;

            mobil.kecepatanMobil();
            mobil.klaksonMobil();
            mobil.tampilInfo();
        }
    }
}