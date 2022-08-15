namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> mylist = new MyList<string>();
            mylist.Add("ANKARA");
            mylist.Add("EŞKİŞEHİR");
            mylist.Add("KASTAMONU");
            mylist.Add("İZMİR");
            mylist.Add("İZMİR");

        }
    }
}
