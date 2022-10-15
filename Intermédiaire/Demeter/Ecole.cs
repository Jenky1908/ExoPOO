using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermédiaire.Demeter
{
    internal class Ecole
    {
        private List<Grade> _grades;

        //Cette méthode ne respecte pas la loi de Delmeter, la classe Ecole n'est censée connaitre que grade et non les classes étudiant

        /*public int CompterEtudiants()
        {
            int nombreEtu = 0;

            foreach (var grade in _grades)
            {
                foreach (var classe in grade.Classes)
                {
                    foreach (var etudiant in classe.Etudiants)
                    {
                        nombreEtu++;
                    }
                }
            }

            return nombreEtu;
        }*/


        //Cette méthode respecte la loi de Demeter 

        public int CompterEtudiants()
        {
            int nombreEtu = 0;

            _grades.ForEach(g => nombreEtu = g.CompterEtudiants());

            return nombreEtu;
        }
    }
}
