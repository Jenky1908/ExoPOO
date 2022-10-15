using _03_Complexe;
using System;

namespace Exercice_Complexe;

class Program
{
    public static void Main(string[] agrs)
    {
        Complexe c1 = new Complexe(4, 6);
        Complexe c2 = new Complexe(-2, 3);

        Console.WriteLine(c1.ToString());
        Console.WriteLine(c2.ToString());

        Console.WriteLine(c1.GetMagnitude());

        Console.WriteLine(Complexe.Sum(c1, c2));
    }
}