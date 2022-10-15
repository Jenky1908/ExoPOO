using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Initiation.Généricité
{
    public class Generic<TGenerique> //Pour définir une classe générique, mettre "<>" avec un paramètre après le nom
    {
        public TGenerique Donnees { get; set; }

        public Generic(TGenerique donnees)
        {
            Donnees = donnees;
        }

        public override string ToString()
        {
            return $"Mon objet (data = {Donnees})";
        }
    }
}
