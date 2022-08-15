using System;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            //CTRL K , CTRL C -->  ŞEÇTİĞİNİZ SATIR COMMENT EDİLİR 
            
            //string[] name = new string[] { "dilek", "melek", "yasemin" };
            //Console.WriteLine(name[0]);
            //Console.WriteLine(name[1]);
            //Console.WriteLine(name[2]);
            // DİZİLER İÇİN - bunu 5 elemanlı yaparsak tekrar newleriz ve eski elemanlar kaybolur .

           List<string> name2 = new List<string>(); // array gibi {} içine elemanlar yazılabillir 
            name2.Add("mehmet");
            name2.Add("şerife");
            name2.Add("simge");
            name2.Add("dobi");

            Console.WriteLine(name2[0]);
            Console.WriteLine(name2[1]);
            Console.WriteLine(name2[2]);
            Console.WriteLine(name2[3]);

        }
    }
}