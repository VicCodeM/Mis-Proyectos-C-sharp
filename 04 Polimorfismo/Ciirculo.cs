using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Ciirculo : IFiguras
    {
        double radio;
        public Ciirculo(double radio)
        {
            this.radio = radio;
        }

        public override string ToString()
        {

            return "Circulo " + radio+ " ";
        }

        public double Area()
        {
            return Math.PI * radio * radio;
        }

        public double Perimetro()
        {
            return 2 * Math.PI * radio;
        }


    }
}
