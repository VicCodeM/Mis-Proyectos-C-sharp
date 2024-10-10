using System;


namespace Banco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double cantidaddinero;
            double anual;
            double pagos;
            double porcentajeanual;
            Console.WriteLine("Dame la cantidad de prestamo");
            cantidaddinero = double.Parse(Console.ReadLine());
            Console.WriteLine("Dame los a;os a pagar");
            anual = int.Parse(Console.ReadLine());
            Console.WriteLine("Dame el Porcentaje");
            porcentajeanual = int.Parse(Console.ReadLine());

            Console.WriteLine("numero de pagos");
            pagos = int.Parse(Console.ReadLine());
            double pagototal = anual * pagos;

            for (int i = 0; i < pagototal; i++)
            {
                cantidaddinero = cantidaddinero + (cantidaddinero * (porcentajeanual / pagos / 100));
            }


            Console.WriteLine("El pago es de {0}", cantidaddinero );

        }
    }
}
