using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermédiaire.DdesignPatterns.Observer.Exemple2
{
    internal class Unsubscriber : IDisposable
    {
        private List<IObserver<ChangementPrixEvent>> _observateurs;

        private IObserver<ChangementPrixEvent> _observer;

        public Unsubscriber(List<IObserver<ChangementPrixEvent>> observateurs, IObserver<ChangementPrixEvent> observer)
        {
            _observateurs = observateurs;
            _observer = observer;
        }

        public void Dispose()
        {
            if (_observateurs != null)
            {
                _observateurs.Remove(_observer);
            }
        }
    }
}
