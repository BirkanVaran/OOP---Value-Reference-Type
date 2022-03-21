using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1._1
{
    class AsistanDoktor : Doktor , INobetTutabilir
    {
        public AsistanDoktor()
        {

        }
        public AsistanDoktor(bool NobetTutarMi)
        {
            this.NobetTutarMi = NobetTutarMi;
            Console.WriteLine("Branşınızı giriniz: ");
            this.Bransi = Console.ReadLine();
        }

        public bool NobetTutarMi { get; set; }
        public DateTime NobetBaslangicTarihi { get; set; }
        public DateTime NobetBitisTarihi { get; set; }
        public decimal NobetSaatlikUcret { get; set; } = 2m;
        public decimal NobetEkOdemesi { get; set; }

        public void NobetDurumunuSor()
        {
        NobetDurum:
            Console.WriteLine("Sayın Asistan Doktor, nöbet tutabilir misiniz? (E/H)");
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

        public void NobetTarihleriniAl()
        {
            Console.WriteLine("Sayın Asistan Doktor, nöbet başlangıç tarihinizi giriniz: ");
            this.NobetBaslangicTarihi = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Sayın Asistan Doktor, nöbet bitiş tarihinizi sistem otomatik olarak hesaplayacaktır.");
            Random rnd = new Random();
            int rastgeleSaat = rnd.Next(24, 72);
            NobetBitisTarihi = NobetBaslangicTarihi.AddHours(rastgeleSaat);
           
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

        public override void PersonelBilgileriniYazdir()
        {
            Console.WriteLine("Doktor bilgileri aşağıdaki gibidir: ");
            base.PersonelBilgileriniYazdir();
            Console.WriteLine("Branş: "+this.Bransi);
            this.NobetUcretlendirmeHesapla();

            if (this.NobetTutarMi)
            {
                Console.WriteLine("Nöbet tarihleriniz: ");
                Console.WriteLine(NobetBaslangicTarihi+ " - "+NobetBitisTarihi);
                Console.WriteLine("Ek ödemeniz: "+NobetEkOdemesi);
                this.Maas += this.NobetEkOdemesi;
                Console.WriteLine("Ek ödeme eklenmiş maaşınız: "+this.Maas);
            }
        }
    }
}
