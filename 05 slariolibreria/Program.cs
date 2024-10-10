using System;
using MyDll;

namespace slariometodo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int h;
            double pph;
            Console.WriteLine("Cuantas horas");
            h= int.Parse(Console.ReadLine());
            Console.WriteLine("Cuanto es el apgo por hora");
            pph= double.Parse(Console.ReadLine());
            Console.WriteLine(Class1.sueldo(h,pph));
        }
    
    }
}
