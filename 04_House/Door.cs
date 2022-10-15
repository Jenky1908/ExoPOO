using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_House
{
    public class Door
    {
        public string Color { get; set; }

        public Door(string color)
        {
            Color = color;
        }

        public void Display()
        {
            Console.WriteLine($"Je suis une porte, ma couleur est {Color}");
        }
    }
}
