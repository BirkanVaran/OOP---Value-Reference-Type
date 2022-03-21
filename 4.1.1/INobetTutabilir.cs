using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1._1
{
    interface INobetTutabilir
    {
        bool NobetTutarMi { get; set; }
        DateTime NobetBaslangicTarihi { get; set; }
        DateTime NobetBitisTarihi { get; set; }
        decimal NobetSaatlikUcret { get; set; }
        decimal NobetEkOdemesi { get; set; }
        void NobetTarihleriniAl(); /*Gövde yok. Gövde, gittiği yerde oluşacak.
                                    * Gittiği yerin koşullarına göre oluşacak.
                                    * Bu nedenle, Interface sadece bir taslak görevi görür. */
        void NobetUcretlendirmeHesapla();
        void NobetDurumunuSor();
    }
}
