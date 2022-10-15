using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermédiaire.TellDontAsk.Exemple2.Bon
{
    internal class Client
    {
        public long Id { get; internal set; } //Ne pourra être modifié que dans le même espace de nom

        public string AdresseClient { get; internal set; } //Ne pourra être modifié que dans le même espace de nom

        public List<Parcelle> Parcelles { get; internal set; } //Ne pourra être modifié que dans le même espace de nom
    }
}
