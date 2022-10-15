using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermédiaire.DdesignPatterns.ChainOfResponsibility
{
    internal abstract class MembreEquipe
    {
        protected string nom;

        protected MembreEquipe successeur; //Pour avoir le membre suivant dans la responsabilité

        protected MembreEquipe(string nom, MembreEquipe successeur)
        {
            this.nom = nom;
            this.successeur = successeur;
        }

        public abstract void handlePlainte(Plainte requete);
    }
}
