using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermédiaire.TellDontAsk.Exemple1.Bon
{
    internal class CompteService : ICompteService
    {
        private readonly CompteRepository _compteRepository;

        public CompteService(CompteRepository compteRepository)
        {
            _compteRepository = compteRepository;
        }

        public void Retrait(int compteId, double montant)
        {
            var compte = _compteRepository.FindById(compteId);

            //if (compte.Solde < montant) //Ici le problème
            //{
            //    throw new ArgumentException("Erreur : pas assez riche...");
            //}

            //compte.Solde -= montant;

            compte.Retrait(montant);

            _compteRepository.Save(compte); //Sauvegarder le nouveau montant du compte dans la base de donnée
        }
    }
}
