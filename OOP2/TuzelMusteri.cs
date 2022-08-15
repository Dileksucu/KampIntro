using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    //şirket vs --> tüzel müşteri
    //Coorporate : tüzel
    //  '' TuzelMusteri :Musteri ''--> BU DURUMA INHRETANCE DİYORUZ (MİRAS ALMA)
    class TuzelMusteri :Musteri
    {
        
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }



    }
}
