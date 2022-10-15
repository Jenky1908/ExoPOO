using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Initiation.Heritage
{
    public class Loup : Animal    
    {
        public Loup(string nom, int age) : base(nom, age)
        {
            //Je remplis ici ce que je veux rajouter en plus
        }

        public override void Deplacer()
        {
            Console.WriteLine("Je cours");
        }

        public override void Espece()
        {
            //base.Espece(); //permet de faire appelle à la méthode par défaut de la classe mère (dire ici que je suis un animal)
            Console.WriteLine("Je suis un Loup");
        }
    }
}
