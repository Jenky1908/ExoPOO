using _01_Cercle;
using System;

namespace Exercice_Cercle;

class Program
{
    public static void Main(string[] agrs)
    {
        Cercle c = new Cercle(6.25);

        Console.WriteLine(c.GetArea());
        Console.WriteLine(c.GetPerimeter());
    }
}