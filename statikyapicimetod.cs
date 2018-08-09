using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication113
{
    class test
    {
        //Not Statik Yapıcı Sınıfla işlem yapıldığında sadece bir kez çalışır. Daha sonra bir daha çalışmaz. 
        // Statik Yapıcı Her türlü işlemde çalışır. Yapıcı nesne türetildiğinde çalışır.
        public static int b; //  statik özellik
        public int a; // özellik 
        static test() // statik yapıcı -- Static Yapıcıya erişim belirteci konulmaz ama public olur.
        {
            Console.WriteLine("Statik Yapıcı");
        }
        public test(int a)  // yapıcı
        {
            Console.WriteLine("Yapıcı");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /// Eğer en başta nesne türetilseydi hem statik yapıcı hem yapıcı metod çalışırdı. 
            /// test t1 = new test(3);
            ///
            test.b = 5; //Statik Yapıcı Çalıştı.
            test.b = 10; // Artık Statik Yapıcı Çalışmaz.
            Console.WriteLine(test.b);

            test t1 = new test(3);//Nesne Türetildiğinde Yapıcı Metod Çalışır. --- Sınıf adı nesne adı = new Yapıcı Metod(Parametre); --- 
            test t2 = new test(3);
            test t3 = new test(3);
        }
    }
}
