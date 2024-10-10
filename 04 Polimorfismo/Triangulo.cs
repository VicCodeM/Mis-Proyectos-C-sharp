using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Triangulo : IFiguras
    {
        double lado1, lado2, lado3;
       
        public Triangulo(double lado1,double lado2, double lado3)
        {
            
            this.lado1 = lado1;
            this.lado2 = lado2;
            this.lado3 = lado3;

        }

        public override string ToString()
        {
            return "Tirangulo " + lado1 + " " + lado2 + " " + lado3 + " ";
        }

        public double Area()
        {
            double semiperimetro = (lado1 + lado2 + lado3) / 2;
            double p = semiperimetro;
            return Math.Sqrt(p * (p - lado1) * (p - lado2) * (p - lado3));
        }
        
        public double Perimetro()
        { 
            return lado1 + lado2 + lado3;
        }
        
    }
}
