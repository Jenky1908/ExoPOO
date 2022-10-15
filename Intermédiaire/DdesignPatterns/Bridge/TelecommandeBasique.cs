using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermédiaire.DdesignPatterns.Bridge
{
    internal class TelecommandeBasique : Telecommande
    {
        public override void AllumerOuEteindre()
        {
            if (appareil.EstActive())
            {
                appareil.Eteindre();
            }
            else
            {
                appareil.Allumer();
            }
        }

        public override void ChangerCanal(int c)
        {
            appareil.ChangerCanal(c);
        }

        public override void ChangerVolume(int v)
        {
            appareil.ChangerVolume(v);
        }
    }
}
