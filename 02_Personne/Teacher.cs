using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Personne
{
    public class Teacher : Personne
    {
        private string subject;

        public void Explain()
        {
            Console.WriteLine("Explanation begins");
        }
    }
}
