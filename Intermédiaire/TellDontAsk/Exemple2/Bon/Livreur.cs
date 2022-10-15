using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermédiaire.TellDontAsk.Exemple2.Bon
{
    internal class Livreur
    {
        List<Client> Clients { get; set; }

        public void Livrer(long clientId)
        {
            var client = Clients.Find(c => c.Id == clientId);

            foreach (var parcelle in client.Parcelles)
            {
                Console.WriteLine($"Livraison parcelle à {client.AdresseClient}");
            }
        }
    }
}
