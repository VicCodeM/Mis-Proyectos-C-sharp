

Console.WriteLine(" Dame el numero del soldado");
int numero = Convert.ToInt32(Console.ReadLine());
int potencia = 0;
while (Math.Pow(2,potencia) < numero)
{
    potencia++;

}
 

double resultado = (numero - Math.Pow(2, potencia-1)+1);
Console.WriteLine(resultado);

Console.ReadKey();





