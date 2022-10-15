using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermédiaire.DdesignPatterns.Proxy
{
    internal class MessageProxy : IMessage
    {
        private IMessage _messageProxifie;

        public MessageProxy(IMessage messageProxifie)
        {
            _messageProxifie = messageProxifie;
        }

        string IMessage.RecupererContenu()
        {
            var contenu = _messageProxifie.RecupererContenu();

            //Faire des vérifications ou transformations (ou mise en cache) >>> on fait une simulation
            string contenuTransforme = contenu.ToUpper();

            return contenuTransforme;
        }
    }
}
