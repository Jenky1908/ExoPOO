using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermédiaire.SOLID.O.Bon
{
    internal class Rectangle : IForme
    {
        public int Longueur { get; internal set; }

        public int Largeur { get; internal set; }

        public Rectangle()
        {

        }

        public Rectangle(int longueur, int largeur)
        {
            Longueur = longueur;
            Largeur = largeur;
        }

        public double Aire()
        {
            return Longueur * Largeur;
        }
    }
}
