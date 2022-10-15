using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Initiation.Interface
{
    public class DbClientService : IClient
    {
        void IClient.AjouterClient(Client c)
        {
            throw new NotImplementedException();
        }

        void IClient.MettreAJourClient(Client c)
        {
            throw new NotImplementedException();
        }

        Client IClient.RecupererClient()
        {
            throw new NotImplementedException();
        }

        List<Client> IClient.RecupererTout()
        {
            throw new NotImplementedException();
        }

        void IClient.SupprimerCLient(Client c)
        {
            throw new NotImplementedException();
        }

        public string GetNomClient(int id)
        {
            return "Alfred de Musset";
        }
    }
}
