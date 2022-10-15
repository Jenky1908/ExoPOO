using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermédiaire.SOLID._5_D.Mauvais
{
    internal class CalculDonneesService
    {
        //Code sans injection de dépendance
        //La méthode dépend de l'objet UtilisateurRepository 
        public object CalculPourUtilisateur(long id)
        {
            UtilisateurRepository utilisateurRepository = new UtilisateurRepository(); //INTERDI (sauf utilisation rapide) >> code instable
            var u = utilisateurRepository.FindById(id);
            //traitement

            return "resultat du traitement";
        }
    }
}
