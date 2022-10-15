using _04_House;

namespace Exercice_Complexe;

class Program
{
    public static void Main(string[] agrs)
    {
        Personne p = new Personne();
        p.Nom = "Jean";
        p.Maison = new Appartement();
        p.Porte = new Door("Rouge");

        p.Display((Appartement)p.Maison);

        Personne p1 = new Personne();
        p.Nom = "Karl";
        p.Maison = new House(500);
        p.Porte = new Door("Bleu");

        p.Display(p.Maison);
    }
}