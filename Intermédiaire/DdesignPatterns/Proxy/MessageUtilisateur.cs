using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermédiaire.DdesignPatterns.Proxy
{
    internal class MessageUtilisateur : IMessage
    {
        private string _contenu;

        public MessageUtilisateur(string contenu)
        {
            _contenu = contenu;
        }

        string IMessage.RecupererContenu() => _contenu; //return _contenu
    }
}
