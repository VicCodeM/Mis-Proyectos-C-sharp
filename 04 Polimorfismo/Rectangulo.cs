using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Rectangulo : IFiguras
    {
        double lado1, lado2;
        public Rectangulo(double lado1, double lado2)
        {
            this.lado1 = lado1;
            this.lado2 = lado2;
        }
        public override string ToString()
        {
            return "Rectangulo " + lado1 + " " + lado2 + " ";
        }
        public double Area()
        {
            return (lado1*lado2);
        }

        public double Perimetro()
        {
            return (lado1 + lado2) * 2;
        }
    }
}
