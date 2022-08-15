using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class ProductManager
    {
        // burada operasyonlar yapılır ; ekleme , silme , gücelleme gibi 
        public void Add( Product product) //metod
         // void methodlarında , return yapılmaz(değer döndüremez) method çağırılmasında kullanılır.
        {
            Console.WriteLine(product.ProductName + " ürünü eklendi .");

        }

        public void Update(Product product) 
        {
            Console.WriteLine(product.ProductName + " güncellendi .");
        }
    }
}
