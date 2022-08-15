namespace OOP2
{
    class Program
    {
        //6.HAFTA DERSİ

        static void Main(string[] args)
        {
            // engin demiroğ

            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo ="12345";
            musteri1.Adi = "engin";
            musteri1.Soyadi = "demiroğ";
            musteri1.TcNo = "544545";


            // Kodlama. iö
             
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.MusteriNo = "54321";
            musteri2.VergiNo = "144565";
            musteri2.SirketAdi = "Kodlama. iö";
            musteri2.Id = 2;

            //Musteri musteri3 = new GercekMusteri(); -->  gerçek müsteriyi de tutar .
            //Musteri musteri4 = new TuzelMusteri(); --> tüzel müşteriyi de tutar .
            
            //--> musteri sınıfının referans Nosu gerçekmusteri'dir 

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);
           // customerManager.Add(musteri3);

        }
    }
      
}