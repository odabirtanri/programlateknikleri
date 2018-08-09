using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication112
{
    class Program
    {
      // Çember sınıfı yapıcı metod olacak set get olcak dolayısıyla pi r ve normal pi r olacak
        class Cember
        {
            public Cember(double r, double pi)//Yapıcı metod
            {
                this.r = r; // =den sonraki parametre olarak gelen r.
                this.pi = pi; // =den sonraki parametre olarak gelen pi.
            }
            public Cember(double r):this(r,3)//Yapıcıyı overload ettik. Gelen r yi gönderip Pi'yi 3 gönderdik.
            { 
            
            }
            public Cember() // Parametresiz gönderilirse yapılacak olan işlem.
            {
                gpi = 3;
            }

            private double gr;
            private double gpi;
            // kapsüllemek için gerçek pi ve gerçek r oluşturuldu.
            public double r
            {
                set
                {
                    if (value < 0) gr = Math.Abs(value);
                    else gr = value;
                }
                get 
                {
                    return gr;
                }
            }
            public double pi
            { 
                set
                {
                    if (value < 3 || value > 3.15) gpi = 3;
                    else gpi = value;
                }
                get 
                {
                    return gpi; 
                }
            }
            public double cevre()
            {
                return 2 * gpi * gr;
            }
            public void yaz()
            {
                Console.WriteLine("---*| Çember Bilgileri |*---");
                Console.WriteLine("Yarı Çapı: "+gr);
                Console.WriteLine("Pi       : "+gpi );
                Console.WriteLine("Çevresi  : "+cevre());
                Console.WriteLine("----------------------------");
                Console.WriteLine();
            }
          

            ~Cember() // Yıkıcı Metod
            {
                Console.WriteLine("Yıkıcı Çalıştı.");
            }
            /// Pi ve R nin kapsülleme işlemi yapıldı.

        }
        static void Main(string[] args)
        {
            if (true)
            {
                Cember c1 = new Cember();
                c1.r = 4;
                c1.pi = 4.14d;
                c1.yaz(); 
            }
            
            Console.ReadLine();
            Cember c2 = new Cember(5);
            c2.yaz();
            Cember c3 = new Cember(6,22d/7d);
            c3.yaz();

        }
    }
}
