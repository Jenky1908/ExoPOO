using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Initiation.Généricité.CasConcret
{
    public class Commande : EntiteBase<int>
    {
        public DateTime Date { get; set; }
    }
}
