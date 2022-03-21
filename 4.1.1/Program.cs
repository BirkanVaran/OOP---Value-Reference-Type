using System;

namespace _4._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
        Baslangic:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" # # # # # HOŞ GELDİNİZ # # # # #");
            Console.WriteLine();
            Console.WriteLine("Eklemek istediğiniz personeli seçiniz: ");

            foreach (var item in Enum.GetValues(typeof(PersonelTurleri)))
            {
                Console.WriteLine(item + "-->"+ (int)item);
            }
            byte personelSeicimi = Convert.ToByte(Console.ReadLine());
            if (personelSeicimi == (int)PersonelTurleri.Hemsire)
            {
                Hemsire h1 = new Hemsire();
                h1.NobetDurumunuSor();
                if (h1.NobetTutarMi)
                {
                    h1.NobetTarihleriniAl();
                }
                h1.PersonelBilgileriniYazdir();
            }
            else if (personelSeicimi==(int)PersonelTurleri.Doktor)
            {
                foreach (var item in Enum.GetValues(typeof(DoktorUnvanlari)))
                {
                    Console.WriteLine($"{item} ---> {(int)item}");
                }
                int doktorSecimi = Convert.ToInt32(Console.ReadLine());
                switch (doktorSecimi)
                {
                    case (int)DoktorUnvanlari.AsistanDoktor:
                        AsistanDoktor asistan1 = new AsistanDoktor();
                        asistan1.NobetDurumunuSor();

                        if (asistan1.NobetTutarMi)
                        {
                            asistan1.NobetTarihleriniAl();
                        }
                        asistan1.PersonelBilgileriniYazdir();
                        break;
                    case (int)DoktorUnvanlari.CerrahiDoktor:
                        CerrahiDoktor cerrah1 = new CerrahiDoktor();
                        cerrah1.PersonelBilgileriniYazdir();
                        break;
                    default:
                        Console.WriteLine("Hatalı giriş yapıldı.");
                        goto Baslangic;
                }
            }
            Console.Read();
            goto Baslangic;
        }
    }
}
