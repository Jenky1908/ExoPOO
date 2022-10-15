using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermédiaire.DdesignPatterns.Command
{
    internal class Serveur //Invoker >> qui va executer la commande
    {
        public void PrendreCommande(ICommander commande)
        {
            commande.Executer();
        }
    }
}
