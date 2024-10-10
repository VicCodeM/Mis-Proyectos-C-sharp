using System;
using System.Threading;

namespace HilosConsola1
{
    internal class Program
    {
        public static void Cantinero1()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Sirve 1 cerveza.. {0}", i);

                Thread.Sleep(100);
            }
            
        }
        public static void Cantinero2()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Sirve 2 cerveza.. {0}",i);
                Thread.Sleep(100);
            }

        }

        static void Main(string[] args)
        {
          // System.Threading.Thread hilo1 = new Thread(Cantinero1);
            Thread hilo1 = new Thread(Cantinero1);
            Thread hilo2 = new Thread(Cantinero2);
         hilo1.Start();
            hilo2.Start();  
        }
    }
}
