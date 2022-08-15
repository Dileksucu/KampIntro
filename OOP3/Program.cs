namespace OOP3
{
    class Program 
    {
        

        //İNTERFACELER KONUSU 
        //interfaceleri biribirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız .

        // krredi tiplerinin hepsi birbirinden farklı 
        //hesapla() fonks kullanır

        static void Main(string[] args)
        {
          // aşağıdakiler ekrandaki kredi çeşitleri (daha sonra ekran haline getirilir ) 
          // aşağıdaki krediler ekrandaki kutucuklardır 
           
            IKrediMananger ıhtiyacKrediManager = new IhtiyacKrediManager();

            IKrediMananger konutKrediManager = new KonutKrediManager();

            IKrediMananger tasitKredisiManager = new TasitKredisiManager();
            
            IKrediMananger esnafkredimanager = new EsnafKrediManager();

            // aşağıdaki instance ile başvuru yapıcaz istediğimiz krediye ( bunlar ekrandaki açılır kutu)


            //Loglama ekranları

            // List<ILoggerService> loggers = new List<ILoggerService>() {databaseLoggerService,fileLoggerService , new SmsLoggerService()}
            // --> çoklu loglama gönderilmek istenirse liste yapılırr foreach ile istenilen loglar sıralanır 

            ILoggerService databaseLoggerService = new DatebaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
           
           


            BasvuruManager basvuruManager = new BasvuruManager();
            
            basvuruManager.BasvuruYap(tasitKredisiManager, fileLoggerService);
            // tasitkredisini , dosyaya logla diyoruz 
           
            basvuruManager.BasvuruYap(esnafkredimanager, databaseLoggerService);
            // tasitkredisini , veritabanına logla diyoruz 

            basvuruManager.BasvuruYap(konutKrediManager,  new SmsLoggerService());
            // tasitkredisini , veritabanına logla diyoruz 


            // Kredi şeçme ekranı 

           
            List<IKrediMananger> krediManangers = new List<IKrediMananger>() {esnafkredimanager,ıhtiyacKrediManager ,konutKrediManager };
            //listeye 2 kredi gönderdi 

            //basvuruManager.KrediOnBilgilendirmesiYap(credits); //gönderilen krediler hesaplandı 



            // IKrediMananger ıhtiyacKrediManager = new IhtiyacKrediManager();
            // yukarıdaki ınstance şu anlama gelir ; ınterfaceler classların referannslarını tutabilirler 


          

        }
    }
}