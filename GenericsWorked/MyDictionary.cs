using HelloWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsWorked
{
    public class MyDictionary<T>
    {
        T[] itemDic;

        public MyDictionary()
        {
            itemDic = new T[0]; // constructor olduğu için boş olamaz arrayin içi 

        }

       public void Add(T item)
       {
            T[] tempArray = itemDic;

            itemDic =  new T[itemDic.Length + 1];  // eleman sayısını 1 arttırdık ( yukarıda 0 dı )
            // eleman sayısını 1 arttırarak newlediğimiz için  tempDic tuttuğumuz elemanlar gitti (biizm arrayimiz tutmuyor artık)
            //eski elemanların yedeğini almamız lazım .(tempArray de tutuyoruz )


            for (int i = 0; i < tempArray.Length ; i++)
            {
                itemDic[i] = tempArray[i];

            }

            itemDic[itemDic.Length - 1] = item;
             
            
       }

       

    }
}
