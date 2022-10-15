using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermédiaire.DdesignPatterns.Adapter
{
    internal interface IJsonAdapter
    {
        string RecupererContactsJson(string cheminFichier);
    }
}
