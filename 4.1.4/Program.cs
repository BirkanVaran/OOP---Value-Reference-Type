using System;

namespace _4._1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Class

            Ogrenci ogr1 = new Ogrenci() { Ad = "Birkan", Soyad = "Varan" };
            Ogrenci ogr2 = new Ogrenci() { Ad = "Deniz", Soyad = "Denizoğlu" };

            Console.WriteLine("og1 Ad Soyad: " + ogr1.Ad + " " + ogr1.Soyad);
            Console.WriteLine("og1 Ad Soyad: " + ogr2.Ad + " " + ogr2.Soyad);

            ogr1 = ogr2; //Refler eşitlendi.
            Console.WriteLine("ogr1, ogr2 refleri eşitlendi.");

            ogr2.Ad = "Lale";
            ogr2.Soyad = "Çiçekoğlu";

            Console.WriteLine("og1 Ad Soyad: " + ogr1.Ad + " " + ogr1.Soyad);
            Console.WriteLine("og1 Ad Soyad: " + ogr2.Ad + " " + ogr2.Soyad);


            //struct
            Student str1 = new Student() { Name = "Betül", Surname = "Akşan" };
            Student str2 = new Student() { Name = "Deniz", Surname = "Denizoğlu" };

            Console.WriteLine("str1 Ad soyad= " + str1.Name + " " + str1.Surname);
            Console.WriteLine("str2 Ad soyad= " + str2.Name + " " + str2.Surname);
            str1 = str2;
            Console.WriteLine("str1 = str2 işlemi yapıldı.");
            str2.Name="Marry";
            str2.Surname="Brown";
            Console.WriteLine("str1 Ad soyad= " + str1.Name + " " + str1.Surname);
            Console.WriteLine("str2 Ad soyad= " + str2.Name + " " + str2.Surname);

            Console.Read();

        }
    }

    struct Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
    class Ogrenci
    {
        public string Ad { get; set; }

        public string Soyad { get; set; }
    }


}
