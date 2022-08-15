using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    //<T> : istenilen type(str,int,bool..) da değer verilebilir .
    public class MyList<T> 
    {
        T[] items; 
        
        // global variable , diğer classlarda kullanabilmek için yazdık.
        

        public MyList() //constructur --> classı newlwersem ilk çalışır direkt.
        {
            items = new T[0]; // 0 elemanlı array oluştuduk , classı newl
        }

        public void Add(T item)
        {  // T Type: int , double, bool .. olabilir  
            
            T[] tempArray = items; 
            
            // newden önceki değerleri tutmak için temp de tutuyoruz . çünkü altta newlediğimiz de array de olan  değerler gider .
           
            items = new T[items.Length + 1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
                
               //tempArray'in tüm elemanlarını items'a (dizisine) aktardık .
                
            }

            items[items.Length - 1] = item;
            
            // tempArray --> items elamanları forla aktarrdık .
            // daha sonra items'ın son elamını hangi dizi de olduğunu buulduk (items.Length - 1) ile --> yabi items[5] de son buldu diye 
            // daha sonra yeni dizi olan item'a eşitledik ki item'a eklenen oradan devam etsin diye  .

        }

    }
}
