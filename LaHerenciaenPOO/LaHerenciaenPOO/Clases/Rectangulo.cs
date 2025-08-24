using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaHerenciaenPOO.Clases
{
    internal class Rectangulo : Figura
    {
        public double Base { get; set; }
        public double Altura { get; set; }
        public Rectangulo(double posicionX, double posicionY, double basee, double altura) : base(posicionX, posicionY)
        {
            Base = basee;
            Altura = altura;
        }
        public override double CalcularArea()
        {
            return Base * Altura;
        }

        public override double CalcularPerimetro()
        {
            return 2 * (Base + Altura);
        }
    }
}
