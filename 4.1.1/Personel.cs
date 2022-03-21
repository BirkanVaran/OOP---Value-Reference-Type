using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1._1
{
    public abstract class Personel
    {
        private string _personelAdi;
        public string PersonelAdi { get => _personelAdi.ToUpper(); set => _personelAdi = value; }
        public string PersonelSoyadi { get; set; }
        public DateTime DTarihi { get; set; }
        public decimal Maas { get; set; }

        private byte _yas;
        public byte Yas
        {
            get
            {
                TimeSpan zamanAraligi = new TimeSpan();
                zamanAraligi = DateTime.Now - DTarihi;
                _yas = (byte)(zamanAraligi.TotalDays / 365);
                return _yas;
            }
        }
        public Cinsiyetler Cinsiyet { get; set; }


        public Personel()
        {
            Console.WriteLine("Özlük bilgilerinizi giriniz.");
            Console.WriteLine("Adınız: ");
            this.PersonelAdi = Console.ReadLine();
            Console.WriteLine("Soyadınız:");
            this.PersonelSoyadi = Console.ReadLine();
            Console.WriteLine("Doğum Tarihiniz:");
            this.DTarihi = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Cinsiyet (E/K)");
            ConsoleKeyInfo secim = Console.ReadKey();
            if (secim.Key==ConsoleKey.E)
            {
                this.Cinsiyet = Cinsiyetler.Erkek;
            }
            else if (secim.Key == ConsoleKey.K)
            {
                this.Cinsiyet = Cinsiyetler.Kadın;
            }

            // Random rnd=  new Random();
            //rnd.Next(5000, 10000);
            // rnd tanımlamadan da yapabiliriz :D
            this.Maas = new Random().Next(5000, 10000);

        }

        public virtual void PersonelBilgileriniYazdir()
        {
            Console.Clear();
            Console.WriteLine("Ad-Soyad: "+this.PersonelAdi+" "+this.PersonelSoyadi.ToUpper());
            Console.WriteLine("Cinsiyeti: "+this.Cinsiyet);
            Console.WriteLine("Yaş: "+this.Yas);
            Console.WriteLine("Maaşı: "+this.Maas);
        }

    }
}
