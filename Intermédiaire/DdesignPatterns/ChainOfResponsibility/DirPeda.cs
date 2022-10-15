using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermédiaire.DdesignPatterns.ChainOfResponsibility
{
    internal class DirPeda : MembreEquipe
    {
        public DirPeda(string nom, MembreEquipe successeur) : base(nom, successeur)
        {
        }

        public override void handlePlainte(Plainte requete)
        {
            if (requete.TypePlainte == Plainte.Types.DirPeda)
            {
                Console.WriteLine("Traitement par le directeur pédagogique");
                requete.EtatPlainte = Plainte.Etats.Ferme;
            }
            else if (successeur != null)
            {
                Console.WriteLine("Le directeur pédagogique a remonté la demande à son chef");
                successeur.handlePlainte(requete);
            }
        }
    }
}
