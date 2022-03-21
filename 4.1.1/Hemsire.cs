using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1._1
{
    class Hemsire : Personel, INobetTutabilir
    {
        public bool NobetTutarMi { get; set; }
        public DateTime NobetBaslangicTarihi { get; set; }
        public DateTime NobetBitisTarihi { get; set; }
        public decimal NobetSaatlikUcret { get; set; } = 1m; //Property'e başlangıç değeri verildi.
        public decimal NobetEkOdemesi { get; set; }

        public Hemsire() // Default CTor
        {

        }

        public Hemsire(bool nobetTutmakIsterMi) // Overload edilmiş CTor
        {
            this.NobetTutarMi = nobetTutmakIsterMi;
        }

        public void NobetTarihleriniAl()
        {
            Console.WriteLine("Sayın hemşire, nöbet başlangıç tarihinizi giriniz: ");
            this.NobetBaslangicTarihi = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Sayın hemşire, nöbet bitiş tarihinizi giriniz: ");
            this.NobetBitisTarihi = Convert.ToDateTime(Console.ReadLine());
        }

        public void NobetUcretlendirmeHesapla()
        {
            double kacSaat = 0;
            decimal nobetEkOdeme = 0m;
            if (this.NobetTutarMi)
            {
                // Kaç saat nöbet tuttuğunu hesaplayalım.
                TimeSpan zamanAraligi = NobetBitisTarihi - NobetBaslangicTarihi;
                kacSaat = zamanAraligi.TotalHours;
                Console.WriteLine("Toplam saat: " + kacSaat);
                nobetEkOdeme = (decimal)kacSaat * NobetSaatlikUcret;
                Console.WriteLine("Ek ödemesi: " + nobetEkOdeme);

            }
            this.NobetEkOdemesi = nobetEkOdeme;
        }

        public override void PersonelBilgileriniYazdir() // Personel classındaki sanal virtual metodu burada override ettik, yani ezdik.
        {
            base.PersonelBilgileriniYazdir();
            this.NobetUcretlendirmeHesapla();
            if (this.NobetTutarMi)
            {
                Console.WriteLine("Nobet ek ödemesi: " + this.NobetEkOdemesi);
                this.Maas += this.NobetEkOdemesi;
                Console.WriteLine("Ek ödeme eklenmiş maaş: " + this.Maas);
            }
        }

        public void NobetDurumunuSor()
        {
        NobetDurum:
            Console.WriteLine("Sayın hemşire, nöbet tutabilir misiniz? (E/H)");
            ConsoleKeyInfo secim = Console.ReadKey();
            Console.WriteLine();
            if (secim.Key == ConsoleKey.E)
            {
                this.NobetTutarMi = true;
            }
            else if (secim.Key == ConsoleKey.H)
            {
                this.NobetTutarMi = false;
            }
            else
            {
                this.NobetTutarMi = false;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("HATALI GİRİŞ. YANITINIZ 'E' YA DA 'H' OLMALIDIR!");
                Console.ResetColor();
                goto NobetDurum;
            }


        }
    }
}
