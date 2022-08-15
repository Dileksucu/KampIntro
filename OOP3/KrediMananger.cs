using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// kredilerin belli kuralları vardır , hepsi Hesapla () functionını belli kurallara göre kullanır .

//bütün ( 100 den fazla ) kredileri burada if(kredi=="") dersek burası kod kalabalığı olur 
// o yüzen bu classtan hepsine kalıtım veririz --> bundan dolayı class değil de interface yaparız KrediManager'ı.

namespace OOP3
{
    interface IKrediMananger
       
      // İNTERFACELERİ --> I İLE BAŞLATIRIZ OKUNURLUĞU ARTTIRMAK İÇİN (IKrediManager gibi)
      //LOGLAMA ---> O SİSTEMDEKİ YAPILAN DEĞİŞİKLİKLERDİR 
      //(YAPILAN İŞLEMLERİN  HEPSİ LOGLAMADIR) 
    {

        public void Hesapla();
        public void BişeyYap();

        // eğer birisi bu ınterface'i kullanması için içindeki
        // içindeki BişeyYap() , Hesapla() fonks kullanması zorunlu .

        // interface bi ara yüz ( şablondur ) -->
        // eğer kullanıcaksan , sen bu arayüze uymaslısın 



    }
}
