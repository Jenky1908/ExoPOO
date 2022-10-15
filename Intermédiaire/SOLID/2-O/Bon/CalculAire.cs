using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermédiaire.SOLID.O.Bon
{
    //Open-Close

    internal class CalculAire
    {
        public double CalculerAire(IForme f)
        {
            return f.Aire();
        }
    }
}
