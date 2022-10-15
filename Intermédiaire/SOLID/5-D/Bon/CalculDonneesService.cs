using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermédiaire.SOLID._5_D.Bon
{
    internal class CalculDonneesService
    {
        private readonly IUtilisateurRepository _repository;

        public CalculDonneesService(IUtilisateurRepository repository) //Etat stable du service
        {
            _repository = repository;
        }

        public object CalculPourUtilisateur(long id)
        {
            var u = _repository.FindById(id);
            //traitement

            return "resultat du traitement";
        }
    }
}
