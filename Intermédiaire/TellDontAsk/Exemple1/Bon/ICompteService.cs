using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermédiaire.TellDontAsk.Exemple1.Bon
{
    internal interface ICompteService
    {
        void Retrait(int compteId, double montant);
    }
}
