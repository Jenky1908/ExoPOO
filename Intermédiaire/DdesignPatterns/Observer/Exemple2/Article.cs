using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermédiaire.DdesignPatterns.Observer.Exemple2
{
    internal class Article : IObservable<ChangementPrixEvent>
    {
        public string Description { get; set; }

        private List<IObserver<ChangementPrixEvent>> _observateurs;

        public Article()
        {
            _observateurs = new List<IObserver<ChangementPrixEvent>>(); //Il faut l'initialiser !
        }

        private double _prix;

        public double Prix
        {
            get { return _prix; }
            set 
            { 
                _prix = value;
                var evt = new ChangementPrixEvent(DateTime.Now, 
                                $"Changement de prix du {Description} : {Prix}");

                _observateurs.ForEach(o => o.OnNext(evt)); //C'est un peu comme o.MettreAJour dans l'exemple 1
            }
        }

        public IDisposable Subscribe(IObserver<ChangementPrixEvent> observer)
        {
            if (!_observateurs.Contains(observer))
            {
                _observateurs.Add(observer);
            }

            return new Unsubscriber(_observateurs, observer);
        }
    }
}
