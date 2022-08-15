using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class BasvuruManager
    {
        // başvuru  bilgileri değerlendirme


        //Method İnjection (dependence injection) konun adı 
        public void BasvuruYap (IKrediMananger krediMananger , ILoggerService loggerServices) 
        {
           
            krediMananger.Hesapla();   // bu şekilde ; başvuruyu kredi bağımsız hale getirdik (sadec 1 kredi göndermedik mesela , bir çok kredi hesaplanabillr hale geldi )
            loggerServices.Log();       // hangi loglayıcı şeçilmişse onu logla diyoruz 


           /* foreach (var loggersevice in loggerServices)
            {
                loggersevice.Log();

            }*/



            // ''public void BasvuruYap(IKrediMananger krediMananger) '' böyle yaparsam 
            // istediğin krediyi gönderip kredinin hesaplasını çalıştırır.


            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            // ÇOKK ÖNEMLİ -->  YUKARIDAKİ KOD ÇALIŞIR AMA TÜM BAŞVURULAR  
            // konutkredisi HESAPLAMA YÖNTEMİYLE HESAPLAR (DESİGN PATTER BUDUR .) 




        }

        public void KrediOnBilgilendirmesiYap ( List<IKrediMananger> credits) 
        {
            //birden fazla kreedinin hesabını yapmak istedeği için list olsun istiyoruz 

            foreach (var credit in credits) 
            {
                credit.Hesapla();

                // list olduğu için foreach ile 3 krediyi dolaşıyoruz
               
            }


        }
    }
}
