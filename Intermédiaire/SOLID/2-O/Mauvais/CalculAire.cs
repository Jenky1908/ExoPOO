using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermédiaire.SOLID.O.Mauvais
{
    //Open-Close
    //Ouverture pour l'extension
    //Fermé pour la modification (=> Non, car à chaque ajout d'une nouvelle forme, on ajoute une méthode à la classe
    internal class CalculAire
    {
        public double CalculAirRectangle(Rectangle r)
        {
            return r.Longueur * r.Largeur;
        }

        public double CalculAirCercle(Cercle c)
        {
            return Math.PI * Math.Pow(c.Rayon, 2);
        }
    }
}
