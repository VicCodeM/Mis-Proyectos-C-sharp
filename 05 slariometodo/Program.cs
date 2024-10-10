using System;


namespace slariometodo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int h;
            double pph;
            Calcular pgo = new Calcular();
            Console.WriteLine("Cuantas horas");
            h= int.Parse(Console.ReadLine());
            Console.WriteLine("Cuanto es el apgo por hora");
            pph= double.Parse(Console.ReadLine());
            Console.WriteLine(pgo.Sueldo(h,pph));
        }
    
    }
}
