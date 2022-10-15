using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Initiation.Encapsulation
{
    public class Rectangle //Par défaut une classe est internal, et il lui est impossible d'être private
    {
        private long Longueur { get; set; }

        private long _largeur; //C'est un champ ou attribut

        private long Largeur //Ici c'est une propriété
        { 
            get
            {
                return _largeur;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("La largeur ne peut être négative");
                }
                else
                {
                    _largeur = value;
                }
            }
        }

        public Rectangle(long longueur, long largeur)
        {
            Longueur = longueur;
            Largeur = largeur;
        }

        public Rectangle() //Constructeur par défaut, à nous de tout faire
        {
            Longueur = 0;
            Largeur = 0;
        }

        public void Redim(long longueur, long largeur)
        {
            Longueur = longueur;
            Largeur = largeur;
        }

        public double Aire()
        {
            return Longueur * _largeur; //Mieux que Longueur * Largeur
        }
    }
}
