using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermédiaire.SOLID._3_L.Bon
{
    internal abstract class AppareilTransportationAvecMoteur : AppareilDeTransportation //Une classe abstraite n'est pas obligée d'implémenter les méthodes abstraites mères
    {
        public Moteur Moteur { get; set; }

        protected AppareilTransportationAvecMoteur(Moteur moteur)
        {
            Moteur = moteur;
        }

        public override void Bouger()
        {
            //Démarer moteur
        }
    }
}
