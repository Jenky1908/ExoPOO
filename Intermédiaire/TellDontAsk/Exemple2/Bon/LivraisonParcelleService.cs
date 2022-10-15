using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermédiaire.TellDontAsk.Exemple2.Bon
{
    internal class LivraisonParcelleService
    {
        public void LivrerParcelle(long clientId)
        {
            //Client client = ClientDao.FindById(clientId);
            //List<Parcelle> parcelles = ParcelleDao.FindByClientId(clientId);

            //foreach (var parcelle in parcelles)
            //{
            //    Console.WriteLine($"Livraison parcelle à {client.AdresseClient}");
            //}

            var livreur = new Livreur();

            livreur.Livrer(clientId);
        }
    }
}
