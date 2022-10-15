using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Initiation.Généricité.CasConcret
{
    public class ProduitDao : IDao<Produit, int>
    {
        Produit IDao<Produit, int>.GetById(int id)
        {
            throw new NotImplementedException();
        }

        int IDao<Produit, int>.Insert(Produit entite)
        {
            throw new NotImplementedException();
        }
    }
}
