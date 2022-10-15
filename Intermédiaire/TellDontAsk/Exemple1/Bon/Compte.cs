using Intermédiaire.TellDontAsk.Exemple1.Mauvais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermédiaire.TellDontAsk.Exemple1.Bon
{
    internal class Compte
    {
        public int Id { get; set; }

        public double Solde { get; set; }

        public Compte(int id, double solde)
        {
            Id = id;
            Solde = solde;
        }

        public void Retrait(double montant) //Ici on modifie directement le compte, c'est la responsabilité de la classe Compte
        {
            if (Solde < montant)
            {
                throw new ArgumentException("Erreur : pas assez riche...");
            }

            Solde -= montant;
        }
    }
}
