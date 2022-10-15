using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Personne
{
    public class Personne
    {
        public int Age { get; set; }

        public Personne()
        {

        }

        public Personne(int age)
        {
            Age = age;
        }

        public void SetAge(int _age)
        {
            Age = _age;       
        }

        public void Hello()
        {
            Console.WriteLine("Hello !");
        }
    }
}
