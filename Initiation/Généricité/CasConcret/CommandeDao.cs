using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Initiation.Généricité.CasConcret
{
    public class CommandeDao : IDao<Commande, int>
    {
        Commande IDao<Commande, int>.GetById(int id)
        {
            throw new NotImplementedException();
        }

        int IDao<Commande, int>.Insert(Commande entite)
        {
            throw new NotImplementedException();
        }
    }
}
