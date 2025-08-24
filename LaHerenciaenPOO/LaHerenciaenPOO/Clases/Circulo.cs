using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaHerenciaenPOO.Clases
{
    internal class Circulo : Figura
    {
        public double Radio { get; set; }

        public Circulo(double posicionX, double posicionY, double radio) : base(posicionX, posicionY)
        {
            Radio = radio;
        }
        public override double CalcularArea()
        {
            return Math.PI * Math.Pow(Radio, 2);
        }

        public override double CalcularPerimetro()
        {
            return 2 * Math.PI * Radio;
        }

    }
}
