using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermédiaire.DdesignPatterns.Command
{
    internal class CommandeDejeuner : ICommander
    {
        public enum Etats
        {
            Cree,
            Prepare
        }

        private ChefCuisinier chef;

        public string ContenuCommande { get; set; }

        public Etats EtatCommande { get; set; }

        public CommandeDejeuner(ChefCuisinier chef, string contenuCommande)
        {
            this.chef = chef;
            ContenuCommande = contenuCommande;
            EtatCommande = Etats.Cree;
        }

        public void Executer()
        {
            chef.CuisinerDejeuner(ContenuCommande);
            EtatCommande = Etats.Prepare;
        }
    }
}
