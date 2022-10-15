using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Initiation.Interface
{
    public interface IClient //Par défaut une interface est public, on est pas obligé de mettre "public" lors des définitions des méthodes
    {
        void AjouterClient(Client c);

        void SupprimerCLient(Client c);

        void MettreAJourClient(Client c);

        List<Client> RecupererTout();

        Client RecupererClient();
    }
}
