using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermédiaire.DdesignPatterns.Observer.Exemple1
{
    internal interface ISujet
    {
        void Attacher(IObservateur observateur);

        void Detacher(IObservateur observateur);

        void Notifier(ISujet sujet);
    }
}
