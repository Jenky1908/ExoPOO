using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermédiaire.DdesignPatterns.ChainOfResponsibility
{
    internal class Plainte
    {
        public enum Types
        {
            Formateur = 1,
            DirPeda,
            Directeur
        }

        public enum Etats
        {
            Ouvert,
            Ferme
        }

        public int NumStagiaire { get; set; }

        public Types TypePlainte { get; set; }

        public string? Message { get; set; }

        public Etats EtatPlainte { get; set; }

        public Plainte(int numStagiaire, Types typePlainte, string? message, Etats etatPlainte)
        {
            NumStagiaire = numStagiaire;
            TypePlainte = typePlainte;
            Message = message;
            EtatPlainte = etatPlainte;
        }
    }
}
