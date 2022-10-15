using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermédiaire.DdesignPatterns.Observer.Exemple1
{
    internal class Produit : ISujet
    {
        public int? Id { get; set; } //Nullable, car on peut demander à la DB (data base) de générer un ID

        public string Description { get; set; }

        private double _prix; //Champ

        internal double Prix
        {
            get { return _prix; }

            set
            { 
                _prix = value; 
                Notifier(this);
            }
        }

        //Pour avoir plusieurs Observateur, on fait une liste (ou un tableau)

        public List<IObservateur> Observateurs { get; set; } //On ne peut pas ajouter dans le programme car elle n'est pas initialisée, il faut faire "new"

        public Produit()
        {
            Observateurs = new List<IObservateur>();
        }

        public void Attacher(IObservateur observateur)
        {
            if (!Observateurs.Contains(observateur))
            {
                Observateurs.Add(observateur);
            }
        }

        public void Detacher(IObservateur observateur) //En vrai pas besoin de vérifier, la méthode Remove ne relève pas d'exception
        {
            if (Observateurs.Contains(observateur))
            {
                Observateurs.Remove(observateur);
            }
        }

        public void Notifier(ISujet sujet)
        {
            foreach (var o in Observateurs)
            {
                o.MettreAJouer(sujet);
            }
        }
    }
}
