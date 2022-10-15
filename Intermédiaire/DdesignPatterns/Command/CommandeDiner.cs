using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermédiaire.DdesignPatterns.Command
{
    internal class CommandeDiner : ICommander
    {
        public enum Etats
        {
            Cree,
            Prepare
        }

        private ChefCuisinier chef;

        public string ContenuCommande { get; set; }

        public Etats EtatCommande { get; set; }

        public CommandeDiner(ChefCuisinier chef, string contenuCommande)
        {
            this.chef = chef;
            ContenuCommande = contenuCommande;
            EtatCommande = Etats.Cree;
        }

        public void Executer()
        {
            chef.CuisinerDiner(ContenuCommande);
            EtatCommande = Etats.Prepare;
        }
    }
}
