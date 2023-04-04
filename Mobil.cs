using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobil
{
    public class Mobil
    {
        //Field
        private string _Warna;
        private string _jumlahPintu;
        private string _Merk;
        private string _Model;
        private string _tahunKeluar;
        private double _Kecepatan;

        //Property
        public string Warna
        {
            get
            {
                return _Warna;
            }

            set
            {
                _Warna = value;
            }
        }

        public string jumlahPintu
        {
            get
            {
                return _jumlahPintu;
            }

            set
            {
                _jumlahPintu = value;
            }
        }

        public string Merk
        {
            get
            {
                return _Merk;
            }

            set
            {
                _Merk = value;
            }
        }
        public string Model
        {
            get
            {
                return _Model;
            }

            set
            {
                _Model = value;
            }
        }

        public string tahunKeluar
        {
            get
            {
                return _tahunKeluar;
            }

            set
            {
                _tahunKeluar = value;
            }
        }

        public double Kecepatan
        {
            get
            {
                return _Kecepatan;
            }

            set
            {
                _Kecepatan = value;
            }
        }
            // My Method
        public void kecepatanMobil()
        {
            Console.WriteLine($"Mobil {Merk} berjalan dengan kecepatan {Kecepatan}");
        }

        public void klaksonMobil()
        {
            Console.WriteLine("Berklakson Tin tin tin");
        }

        public void tampilInfo()
        {
            Console.WriteLine($"Mobil saya berwarna {Warna}, Dengan Merk {Merk}, Dan BerModel {Model}, Keluaran Tahun {tahunKeluar}, Dengan Jumlah Pintu Sebanyak {jumlahPintu} Pintu");
        }
    }
}