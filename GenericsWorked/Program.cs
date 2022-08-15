using GenericsWorked;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            MyDictionary<string> myDictionary = new MyDictionary<string> ();
            
            myDictionary.Add("ANKARA");
            myDictionary.Add("EŞKİŞEHİR");
            myDictionary.Add("KASTAMONU");
            myDictionary.Add("ERZİNCAN");
            myDictionary.Add("İZMİR");

            MyDictionary<string> myDictionary2 = new MyDictionary<string>();
            myDictionary.Add("MEHMET");
            myDictionary.Add("ŞERİFE");
            myDictionary.Add("YASEMİN");
            myDictionary.Add("MELEK");
            myDictionary.Add("DİLEK");



        }
    }
}