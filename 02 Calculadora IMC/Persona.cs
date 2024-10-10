using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_IMC
{
    internal class Persona
    {
        public double peso;//kg
        public double estatura;//metros
        public string nombre;

        public Persona(string nombre, double estatura, double peso)
        {
            this.nombre = nombre;
            this.estatura = estatura;
            this.peso = peso;
        }
        public double CalcIMC()
        {
            if(estatura==0) return -1;
            return peso/(estatura*estatura);
        }
        public override string ToString()
        {
            return nombre + " " + peso + " " + estatura;
        }
    }
}
