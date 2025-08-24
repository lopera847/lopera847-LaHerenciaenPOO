using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaHerenciaenPOO.Clases
{
   internal abstract class Figura
    {
        public double PosicionX  { get; set; }
        public double PosicionY { get; set; }

        public Figura(double posicionX, double posicionY)
        {
            PosicionX = posicionX;
            PosicionY = posicionY;
        }

        public abstract double CalcularArea();
        public abstract double CalcularPerimetro();

    }
}
