using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Initiation.Généricité.CasConcret
{
    public class Produit : EntiteBase<int>
    {
        public string Libelle { get; set; }

        public double Prix { get; set; }
    }
}
