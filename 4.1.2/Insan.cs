using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1._2
{
    class Insan
    {
        // Classlar Reference Type'tır.

        public string Ad;
        public int Yas;


        public bool? EhliyetiVarMi { get; set; } /* Normal şartlarda bool tipli bir değişken asla ve asla null olamaz.
                                                  * Bu nedenle default olarak false atanabilir.
                                                  * Fakat faşse atandığınd sanki kullanıcı ehliyeti yok gibi davanmış olur.
                                                  * Bu nedenle bool olmasına rağmen null değerine izin verelim.*/

    }
}
