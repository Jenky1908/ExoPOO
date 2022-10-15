using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermédiaire.SOLID.S
{
    internal class Employe
    {
        public string Nom { get; set; }

        //Embaucher n'est pas de la responsabilité de Employe
        /*public void Embaucher(Employe e, DateTime dateEmbauche)
        {

        }*/
    }
}
