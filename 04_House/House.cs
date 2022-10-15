using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_House
{
    public class House
    {
        public double _surface;
        public double Surface
        {
            get
            {
                return _surface;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("La surface ne peut être négative");
                }
                else
                {
                    _surface = value;
                }
            }
        }

        public House()
        {

        }

        public House(double surface)
        {
            Surface = surface;
        }

        public void Display()
        {
            Console.WriteLine($"Je suis une maison, ma surface est de {_surface} m2");
        }

        public Door GetDoor(Door porte)
        {
            return porte;
        }
    }
}
