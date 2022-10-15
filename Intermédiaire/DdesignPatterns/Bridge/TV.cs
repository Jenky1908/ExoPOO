using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermédiaire.DdesignPatterns.Bridge
{
    internal class TV : IAppareil
    {
        void IAppareil.Allumer()
        {
            throw new NotImplementedException();
        }

        void IAppareil.ChangerCanal(int c)
        {
            throw new NotImplementedException();
        }

        void IAppareil.ChangerVolume(int v)
        {
            throw new NotImplementedException();
        }

        bool IAppareil.EstActive()
        {
            throw new NotImplementedException();
        }

        void IAppareil.Eteindre()
        {
            throw new NotImplementedException();
        }
    }
}
