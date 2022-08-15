using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class IhtiyacKrediManager : IKrediMananger
    {
        //Herkes kendi kuralllarını yazabilir şimdi 
        public void BişeyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla() 
        {
            Console.WriteLine("ihtiyaç kredisi hesaplandı ");
        
        }
    }
}
