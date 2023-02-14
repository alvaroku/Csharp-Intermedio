using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces.Interfaces;

namespace Interfaces.Implementaciones
{
    public class Multiplicacion : IOperacion
    {
        private double Resultado = 0;
        public void Calcular(double a, double b)
        {
            Resultado = a * b;
        }
        public void Mostrar()
        {
            Console.WriteLine("El resultado es {0}", Resultado);
        }
    }
}
