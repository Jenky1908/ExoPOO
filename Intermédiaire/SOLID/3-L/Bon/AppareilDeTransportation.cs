using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermédiaire.SOLID._3_L.Bon
{
    internal abstract class AppareilDeTransportation
    {
        public string Nom { get; set; }

        public int Speed { get; set; }

        public abstract void Bouger();
    }
}
