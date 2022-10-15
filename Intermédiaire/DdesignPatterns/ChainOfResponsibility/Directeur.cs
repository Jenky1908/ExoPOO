namespace Intermédiaire.DdesignPatterns.ChainOfResponsibility
{
    internal class Directeur : MembreEquipe
    {
        public Directeur(string nom, MembreEquipe successeur) : base(nom, successeur)
        {
        }

        public override void handlePlainte(Plainte requete)
        {
            Console.WriteLine("Traitement par le directeur");
            requete.EtatPlainte = Plainte.Etats.Ferme;
        }
    }
}
