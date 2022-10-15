using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermédiaire.DdesignPatterns.Bridge
{
    internal interface IAppareil
    {
        bool EstActive();

        void ChangerVolume(int v);

        void ChangerCanal(int c);

        void Allumer();

        void Eteindre();
    }
}
