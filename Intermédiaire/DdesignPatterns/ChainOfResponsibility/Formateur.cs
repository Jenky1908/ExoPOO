using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermédiaire.DdesignPatterns.ChainOfResponsibility
{
    internal class Formateur : MembreEquipe
    {
        public Formateur(string nom, MembreEquipe successeur) : base(nom, successeur)
        {

        }

        public override void handlePlainte(Plainte requete)
        {
            if (requete.TypePlainte == Plainte.Types.Formateur)
            {
                Console.WriteLine("Traitement par le formateur");
                requete.EtatPlainte = Plainte.Etats.Ferme;
            }
            else if (successeur != null)
            {
                Console.WriteLine("Le formateur a remonté la demande à son chef");
                successeur.handlePlainte(requete);
            }
        }
    }
}
