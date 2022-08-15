using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    //eğer ki bir nesne de bir değeri kullanmak zorunda görünmüyorsa o alan demekki orada soyutlama hatası yapıyorsun deriz 
    // demek istiyor ki şahış  biligileriyle illgili bir musteri nesnesi oluşturursak , burada SirketAdi'nı kullanamayız
    //bu da soyutlama hatası olur , o yüzden farklı classlar oluşturulur 
   
    // Musteri base classtır. (kalıtım alınan class)
    public class Musteri
    {
        //tüzel ve gerçek müşteri de ortak alanlardır . o yüzden miras aldık bu classtan .
        public int Id { get; set; }
        public string MusteriNo { get; set; }

    }
}
