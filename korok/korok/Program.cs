using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace korok
{
    class Kor
    {
        public double Sugar { get; set; }
        public double Ter()
        {
            double Terulet =Math.Round( Sugar * Sugar * Math.PI,2);
            return Terulet;
        }
        public double Ker()
        {
            double Kerulet =Math.Round( 2 * Sugar * Math.PI,2);
            return Kerulet;
        }
        public Kor(double sugar)
        {
            Sugar = sugar;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var k1 = new Kor(5);
            Console.WriteLine($"A kör kerülete:{k1.Ker()}, a kör területe:{k1.Ter()}" );
            Console.ReadKey();
        }
    }
}
