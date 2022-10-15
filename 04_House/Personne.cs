using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_House
{
    public class Personne
    {
        public string Nom { get; set; }

        public House Habitation { get; set; }

        public Door Porte { get; set; }

        public Personne()
        {

        }

        public Personne(string nom, House habitation, Door porte)
        {
            Nom = nom;
            Habitation = habitation;
            Porte = porte;
        }

        public void Display(House maison)
        {
            Console.WriteLine($"Mon nom est {Nom}, ma maison fait {maison.Surface} m2, et ma porte est {Porte.Color}");
        }

        public void Display(Appartement appartement)
        {
            Console.WriteLine($"Mon nom est {Nom}, mon appartement fait {appartement.Surface} m2, et ma porte est {Porte.Color}");
        }
    }
}
