using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaHerenciaenPOO.Clases
{
    internal class Triangulo : Figura
    {
        public double Lado1 { get; set; }
        public double Lado2 { get; set; }
        public double Lado3 { get; set; }

        public Triangulo(double x, double y, double lado1, double lado2, double lado3) : base(x, y)
        {
            Lado1 = lado1;
            Lado2 = lado2;
            Lado3 = lado3;
        }

        public override double CalcularArea()
        {
            double s = (Lado1 + Lado2 + Lado3) / 2;
            return Math.Sqrt(s * (s - Lado1) * (s - Lado2) * (s - Lado3)); 
        }

        public override double CalcularPerimetro()
        {
            return Lado1 + Lado2 + Lado3;
        }
    }
}
