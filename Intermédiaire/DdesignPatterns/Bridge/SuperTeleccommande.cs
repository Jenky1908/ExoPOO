using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermédiaire.DdesignPatterns.Bridge
{
    internal class SuperTeleccommande : TelecommandeBasique //On rafine
    {
        public void Sourdine()
        {
            ChangerVolume(0); // /|\ on peut écrire appareil.ChangerVolume(0); mais vaut mieux ne pas le faire, sinon s'il y a un changement, il faut changer partout
        }
    }
}
