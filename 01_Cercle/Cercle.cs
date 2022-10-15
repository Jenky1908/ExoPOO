using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Cercle
{
    public class Cercle
    {
        public double Rayon { get; set; }

        public Cercle()
        {

        }

        public Cercle(double rayon)
        {
            Rayon = rayon;
        }

        public double GetArea()
        {
            return 3.14 * (Rayon * Rayon);
        }

        public double GetPerimeter()
        {
            return 2 * 3.14 * Rayon;
        }
    }
}
