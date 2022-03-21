using System;

namespace _4._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Value Type - Bu tür değişkenler belleğin stack bölümünde tutulur.

            int sayiA = 5;
            //sayi A = null; // Integer değişkene null ataması yapamayız.

            int sayiB = 10;
            sayiA = sayiB; // B'yi A'nın içine attık.
            Console.WriteLine("SayiA = " + sayiA); //B'deki değeri yazacak, çünkü atamasını yaptık.
            sayiB = 15;
            Console.WriteLine("SayıB = " + sayiB);

            Insan insan1 = new Insan();
            insan1.Ad = "Birkan";
            insan1.Yas = 27;

            Insan insan2 = new Insan() { Ad = "Deniz", Yas = 20 };
            insan1 = insan2; /* insan2'yi insan1'e atadık.
                              * insan1'de artık Deniz 20 var.
                              *Ama insan1'in ref adresi yok oldu.
                              insan2'nin ref adresi neyse o adrese sahip.*/
            Console.WriteLine("insan1: "+insan1.Ad+ " "+ insan1.Yas);
            insan2.Ad = "Bulut";
            insan2.Yas = 19;

            /* Aşağıdaki koddan beklenen ekrana Bulut 19 yazmaası.
             * aslında insan2 update edildi ama insan1'in ref adresi insan 2 ile aynı olduğundan
             *o ref'te kim varsa o bilgiyi getirecek.
             * Bu nedenle ekranda Bulut 19 olarak görünecek.*/
            Console.WriteLine("insan2: "+insan1.Ad+ " "+ insan1.Yas);

            Insan insan3; // reference type'lar bu şekilde tanımlanırsa null olurlar.

            insan3 = null; /* ? operatörü nullable olup olmasına izin vermek anlamına gelir.
                            * Yani önce gidip insan3'ü null mı değil mi diye kontrol eder,
                            * ve null olmasına izin veriyor.
                            * Normalde insan3.Ad yazınca hata verirken, insan3?.Ad yazınca vermiyor.
                            * Çünkü nullable olmasına izin veriyoruz.
                            * int'e yazmamamızın sebebi int'in null olma durumu yok.
                            * Çünkü value type bir değişkendir. Arka planda default bir değeri var. */

            Console.WriteLine("insan3: "+insan3?.Ad);
            Console.WriteLine("insan3: "+insan3?.Yas);

            // Normalde böyle kullanmalıyız.
            if (insan3 != null)
            {
                if (insan3.Yas<18)
                {
                    Console.WriteLine("18 yaşından küçükler üye olamazlar.");
                }
            }

            if (insan3?.Yas<18)
            {
                Console.WriteLine("18 yaşından küçükler üye olamazlar.");
            }
            
            // String özel bir tiptir.
            // Normalde string valueType bir değişkendir. Fakat null değeri de alabilir.
            string Ad1 = "Birkan";
            string Ad2 = "Deniz";
            Console.WriteLine("Ad1: "+Ad1);
            Ad1 = Ad2;
            Ad2 = "Deneme";
            Console.WriteLine("Ad1: "+Ad1);
            string Ad3 = null; /* string'e null verebilirim. Ama int'e bool'a veremeyiz.
                                * Neden string'e null verebiliyoruz? ---> String özel tip olduğu için. */
            Console.Read();

        }
    }
}
