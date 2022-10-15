using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermédiaire.DdesignPatterns.Command
{
    internal class ChefCuisinier //Receiver
    {
        public void CuisinerDejeuner(string contenuCommande)
        {
            Console.WriteLine($"Service du midi pour : {contenuCommande}");
        }

        public void CuisinerDiner(string contenuCommande)
        { 
            Console.WriteLine($"Service du soir pour : {contenuCommande}"); 
        }
    }
}
