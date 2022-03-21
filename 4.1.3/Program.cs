using System;

namespace _4._1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStruct1 benimStructNesnem = new MyStruct1(); /* new ile türetilmesi classlara benziyor.
                                                            * Ama class gibi reference type değildir.
                                                            * Value Type'tır. Bellekte stack'ta tutulur. */
            {

                /* Propertyler atanmadı, default değer ne ise o geldi: */

                Console.WriteLine(benimStructNesnem.Ad);
                Console.WriteLine(benimStructNesnem.Yas);
                Console.WriteLine(benimStructNesnem.Durum);
                

                // Struct new keyword'ü olmadan da türetilebiliyor.

                MyStruct1 benimStructNesnem2;

                benimStructNesnem2.Ehliyeti = true;
                benimStructNesnem2.KursununAdi = "Network Akademiz";

                Console.WriteLine(benimStructNesnem2.Ehliyeti);
                Console.WriteLine(benimStructNesnem2.KursununAdi);

            }
            Console.Read();
        }
    }

    struct MyStruct1
    {
        /* Struct - Yapı demektir
         * Vale Type'tır.
         * Struct'tan Struct'a kalıtım yoktur.
         * Aynı zamanda classlardan da kalıtım alamazlar.
         * Interface'ten kalıtım alabilir. */

        /* İstisna özelliği:
         * Struct yapıaları new ile türetilebilir.
         * Eğer new ile türetiliyorsa belleğin heap kısmında tutulur.
         * (Bu özelliği ile class'a benzer.) */


        // Struct içindeki field'lara da default değeri atanmış olacak.
        public int Yas { get; set; }
        public string Ad { get; set; }
        public bool Durum { get; set; }
        public bool Ehliyeti;
        public string KursununAdi;
    }

    struct MyStruct2
    {

    }
}
