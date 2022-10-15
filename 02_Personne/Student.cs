using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Personne
{
    public class Student : Personne
    {
        public void GoToClasses()
        {
            Console.WriteLine("I'm going to class");
        }

        public void DisplayAge(Age age)
        {
            Console.WriteLine($"My age is : {age} years old");
        }
        
    }
}
