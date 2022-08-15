using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
     class Product 
    {
        // entity - varlık gibi isimler verilebilir classlara,sadece ve sadce özellik olur 
        // bu alanlar foreign key olan anahtarlardır 
        public int Id { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; } //ürünün birim fiyatı 
        public int CategoryId { get; set; } // kategori ıd 
        public int UnitsInStock { get; set; } // stoktaki adeti 




    }
}
