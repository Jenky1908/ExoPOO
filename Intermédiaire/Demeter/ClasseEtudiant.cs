using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermédiaire.Demeter
{
    internal class ClasseEtudiant
    {
        public IList<Etudiant> Etudiants { get; internal set; } //Plus général que List<>

        public int CompterEtudiants()
        {
            return Etudiants.Count;
        }
    }
}
