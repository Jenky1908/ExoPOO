using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermédiaire.SOLID.O.Bon
{
    internal class Cercle : IForme
    {
        public double Rayon { get; internal set; }

        public Cercle()
        {

        }

        public Cercle(double rayon)
        {
            Rayon = rayon;
        }

        public double Aire()
        {
            return Math.PI * Math.Pow(Rayon, 2);
        }
    }
}
