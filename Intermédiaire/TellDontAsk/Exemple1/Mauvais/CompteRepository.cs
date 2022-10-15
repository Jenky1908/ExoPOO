using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermédiaire.TellDontAsk.Exemple1.Mauvais
{
    internal class CompteRepository
    {
        public Compte FindById(int id)
        {
            return null; //Requête Sql pour récupérer les doonnées
        }

        public void Save(Compte c)
        {
            //Enregistrement en base de données
        }
    }
}
