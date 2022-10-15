using _02_Personne;
using System;

namespace Exercice_Personne;

class Program
{
    public static void Main(string[] agrs)
    {
        Personne p1 = new Personne();
        Student p2 = new Student();
        Teacher p3 = new Teacher();

        p1.Hello();

        p2.SetAge(15);
        p2.Hello();
        p2.GoToClasses();

        p3.SetAge(40);
        p3.Hello();
        p3.Explain();
    }
}
