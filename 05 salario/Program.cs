Console.WriteLine("Vamos a calcular salario");
Console.WriteLine("Dame las horas ");
int horas = int.Parse(Console.ReadLine());
Console.WriteLine("Dame el pago por hora");
int pagoh=int.Parse(Console.ReadLine());

double pago = 0;
if (horas <= 40)
{
    pago = horas * pagoh;

    Console.WriteLine("El pago es de {0}", pago);
}else if (horas <= 52)
    
{
    pago = 40 * pagoh + horas-40*pagoh*2;
        
    Console.WriteLine("El pago es de {0}", pago);

}else if
 (horas > 52)
{
    pago = 40 * pagoh +12* horas *2 * pagoh * 2 + horas -52 *pagoh*3;
   
    Console.WriteLine("El pago es de {0}", pago);
}
