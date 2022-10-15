using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermédiaire.DdesignPatterns.Observer.Exemple2
{
    internal class ChangementPrixEvent
    {
        public DateTime Date { get; set; }

        public string MessageNotif { get; set; }

        public ChangementPrixEvent(DateTime date, string messageNotif)
        {
            Date = date;
            MessageNotif = messageNotif;
        }
    }
}
