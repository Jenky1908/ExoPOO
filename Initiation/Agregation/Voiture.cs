using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Initiation.Agregation
{
    public sealed /*Pas d'héritage possible de Voiture, mais voiture peut hériter*/ class Voiture
    {
        //Agrégation forte : voiture ne peut pas exister sans moteur
        public Moteur Moteur { get; init; } //Seulement modifiable dans le constructeur

        public Voiture(Moteur moteur)
        {
            Moteur = moteur;
        }

        //Association (temporaire) : voiture utilise objet Parking de manière temporaire

        public void Garer(Parking parc)
        {
            parc.Garer(); //La méthode Garer de voiture utilise la méthode Garer de Parking
        }
    }
}
