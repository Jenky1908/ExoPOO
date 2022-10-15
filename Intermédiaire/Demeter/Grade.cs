using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermédiaire.Demeter
{
    internal class Grade
    {
        public IList<ClasseEtudiant> Classes { get; internal set; }

        public int CompterEtudiants()
        {
            int nombreEtu = 0;

            foreach (var c in Classes)
            {
                nombreEtu += c.CompterEtudiants();
            }

            return nombreEtu;
        }
    }
}
