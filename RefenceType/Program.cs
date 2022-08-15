using OOP1;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
           // int,double,bool..... değer tip --> değeri üzerinden metoda  atanır (methodun içinde sayı atansa bile).
           //dizi,inteface,abstract,class .. referans tip (bellekteki adresiyle atanır) .
            
            Product product1 = new Product();
            product1.Id = 1;
            product1.ProductName = "Masa";
            product1.CategoryId = 2;
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product();
            product2.Id = 2;
            product2.ProductName = "Sandalye";
            product2.CategoryId = 3;
            product2.UnitPrice = 1500;
            product2.UnitsInStock = 10;

            // case sensitive ; büyük küçük harfe duyarlı
            // ProductManager productManager = stackte oluşturduk
            //new ProductManager(); = Heap de oluşturduk 

            ProductManager productManager = new ProductManager();
            //bu oluşturmaya insatance creation denir 
            productManager.Add(product1);
            productManager.Add(product2);

            
    



            



        }
    }
}