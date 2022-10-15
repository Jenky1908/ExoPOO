using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermédiaire.DdesignPatterns.Bridge
{
    internal abstract class Telecommande //Utiliser classe abstraite et non une interface pour partager le champ IAppareil
    {                                 
        protected IAppareil appareil; //Voilà le bridge

        public void DefinirAppareil(IAppareil appareil)
        {
            this.appareil = appareil;
        }
        
        public abstract void ChangerVolume(int v);

        public abstract void ChangerCanal(int c);

        public abstract void AllumerOuEteindre();
    }
}
