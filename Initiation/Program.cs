using Initiation.Encapsulation;
using Initiation.Généricité;
using Initiation.Généricité.CasConcret;
using Initiation.Heritage;
using Initiation.Interface;
using Initiation.Polymorphisme;
using System;

namespace Initiation;

class Program
{
    public static void Main(string[] agrs)
    {
        //"static" évite d'être instanciable

        #region Bases

        //Tableau 1 dimension

        int[] ints = { 1, 2, 3 };
        int[] monTab = new int[5]; //ici 5 est la taille du tableau
        monTab[0] = 50;
        monTab[1] = 15;

        Console.WriteLine(monTab[1]);

        monTab[2] = 13;
        monTab[3] = 1;
        monTab[4] = 3;

        Console.WriteLine(monTab.Length);

        //++i
        //int i = 0;
        //i = i + 1;
        //Console.WriteLine(i);

        //i++
        //i = 0;
        //Console.WriteLine(i);
        //i = int + 1;

        //1er méthode pour afficher tout le contenu d'un tableau

        for (int i = 0; i < monTab.Length; ++i) //++i prend moins de ressource
        {
            Console.WriteLine(monTab[i]);
        }

        //2e méthode

        foreach (var item in monTab)
        {
            Console.WriteLine(item);
        }

        //3e méthode (boucle for qui représente ce que fait un foreach)

        for (int i = 0; i < monTab.Length; i++)
        {
            var item = monTab[i];

            Console.WriteLine(item);
        }

        //Tableau à plusieurs dimensions

        int[,] matrice = new int[2, 3];
        matrice[0, 0] = 10;
        matrice[0, 1] = 15;
        matrice[0, 2] = 19;
        matrice[1, 0] = 78;
        matrice[1, 1] = 254;
        matrice[1, 2] = 597;

        int[,] matrice2 = { { 10, 20, 30 }, { 40, 50, 60 } };

        //Le nomre de boucle correspond au nombre de dimension du tableau

        for (int i = 0; i < matrice2.GetLength(0); ++i)
        {
            AfficherColonnes(matrice2, i);
        }

        //Pour foreach, il n'y a besoin que d'une seule boucle foreach pour tout afficher

        foreach (var item in matrice2)
        {
            Console.WriteLine(item);
        }

        //string[][][] tabString;
        //tabString[0][1][3] = ...;

        //ALgo recherche un élément
        string[] transport = { "Moto", "Voiture", "Camion", "Avion" };
        var trouve = false;
        Console.Write("Entrez le transport à rechercher ! ");
        var recherche = Console.ReadLine();

        for (int i = 0; i < transport.Length; ++i)
        {
            if (transport[i].Equals(recherche))
            {
                trouve = true;
                break;
            }
        }

        Console.WriteLine(trouve);

        //Appelle à la méthode

        Soustraction(9, 3); //Affiche le résultat de 9-3

        var res = Soustraction2(15, 6); //La variable prend la valeur retournée par la fonction, ici ce qui est retourné est 15-6;

        Console.WriteLine(Somme(1, 2)); //c = 3 déjà

        var a = 10;
        var b = 13;

        Permutation(ref a, ref b); 
        
        Console.WriteLine(a); //Affichera 13

        double resSomme, resMoy;
        var resMod = Calcul(12, 40, out resSomme, out resMoy); //NE PAS OUBLIER LE "OUT"

        Console.WriteLine(resSomme); //Ici : 52
        Console.WriteLine(resMoy); //Ici : 26
        Console.WriteLine(resMod); //Ici : 12

        var a2 = 56;
        var b2 = 78;

        var resMult = Multiplication(a2, b2); //Ici on n'est pas obligé de mettre "IN"


        //IN : lire (état un peu par défaut)
        //OUT : écrire
        //REF : lire et écrire


        var estMajeur = EstMajeur(out int age); //Je peux déclarer directement à l'appel à la fonction
        Console.WriteLine(estMajeur);
        Console.WriteLine(age);

        


        /***********************************EXCEPTION************************************/


        //Principe de responsabilité unique : ne pas mettre tous les try catch dans le Main, et mettre dans des endroits stratégiques


        //L'ordre des catch est important : mettre le plus précis au plus global

        try //Ne pas écrire 10.000 lignes dans le try, juste l'essentiel
        {
            var resDiv = Division(null, 0);
        }
        catch (ArgumentOutOfRangeException e) //Mieux que ArgumentException, c'est plus précis
        {
            Console.WriteLine(e.Message); //Affiche le message qu'on a défini pour l'exception
        }
        catch(ArgumentException)
        {
            Console.WriteLine("Problème d'argument");
        }
        /*catch (NullReferenceException)
        {
            Console.WriteLine("Calcul impossible : une ou plusieurs variable(s) non initialisée(s) !!!");
        }
        Pas besoin de le mettre ici, la méthode Division s'en charge
        */
        catch (DivideByZeroException)
        {
            Console.WriteLine("Calcul impossible : division par zéro !!!");
        }
        catch (Exception /*ex*/) //Mettre un catch avec "Exception" afin de couvrir toutes les exceptions au besoin en cas de doute, au parent le plus haut
        {
            //Console.WriteLine(ex.Message);
            Console.WriteLine("Calcul impossible !!!");
        }

        #endregion

        #region POO

        /******************************************Programmation Orientée Objet******************************************/


        //Encapsulation : permet de ne pas révéler tous les détails du programme grâce au accesseurs, et modifier les données de la classe
         
        var rect = new Rectangle(56, 19);
        ////rect.longueur = 180; //A ne pas faire !!!
        //rect.Longueur = 180;
        //rect.Largeur = 42;
        //var _air = rect.Longueur*rect.Largeur;
        var aire = rect.Aire();

        
        //Interface :

        IClient client = new WebClientService(); //Je peux interchanger avec DbClientService sans casser le code en utilisant l'interface et non les classes concrètes
        client.AjouterClient(null);
        client.SupprimerCLient(null);
        (client as DbClientService).GetNomClient(1); //Il faut convertir client car seul la classe concrète possède la méthode GetNomClient


        //Héritage :

        Animal ani = new Loup("ni", 15);
        ani.GetInfos();



        //Genericité :

        var gen = new Generic<int>(12);
        gen.Donnees = 5;

        IDao<Produit, int> produitService = new ProduitDao();
        IDao<Commande, int> commandeService = new CommandeDao();

        produitService.GetById(1);
        commandeService.GetById(1);


        //Polymorphisme

        IPliable table = new Table();

        PolyTest.Acheter(table);


        #endregion


        Console.ReadLine();
    }




    


    /********************************************************************************/








    //Selectionner la partie à "Méthoder", puis renommer la méthode créée
    private static void AfficherColonnes(int[,] matrice2, int i)
    {
        for (int j = 0; j < matrice2.GetLength(1); ++j)
        {
            Console.WriteLine(matrice2[i, j]);
        }
    }

    //Méthodes : Procédure (ne retourne rien) != Fonction

    //Procédure

    public static void Soustraction(int a, int b)
    {
        Console.WriteLine(a - b);
    }

    //Fonction

    public static int Soustraction2(int a, int b)
    {
        return a - b;
    }

    /*********************************************************************************/

    public static void AfficherTab(short[] tab)
    {
        foreach (var item in tab)
        {
            Console.WriteLine(item);
        }
    }

    public static int Somme(int a, int b, int c = 3) //c est un paramètre optionnel, et possède une valeur par défaut
    {
        return a + b + c;
    }

    public static void Permutation(ref int a, ref int b)
    {
        int c = a;
        a = b;
        b = c;
    }

    //Pour récupérer plusieurs résultat dans une fonction >> utiliser OUT
    public static double Calcul(double a, double b, out double somme, out double moy) //somme et moy sont des variables de sortis uniquement
    {
        somme = a + b;
        moy = (a + b) / 2;

        return a % b;
    }

    //IN : que lire la variable

    public static int Multiplication(in int a, in int b)
    {
        // a = b; impossible car a est en lecture seule, on peut pas toucher à sa valeur, idem pour b 
        return a * b;
    }

    public static bool EstMajeur(out int age) //Obligation d'assigner une valeur à la variable qui est out
    {
        Console.Write("Ecrivez votre âge : ");
        var _age = Convert.ToInt32(Console.ReadLine());

        age = _age; //Pour que la variable age ne soit pas en nulle en sorti

        if (_age >= 18)
        {
            return true;
        }
        return false;       
    }

    public static double? /*| peut retourner null*/ Division(double? a, double? b)
    {
        if (a.HasValue)
        {
            if (a > 5)
            {
                throw new ArgumentOutOfRangeException("a est suépieur à 5"); //Création d'une exception
            }
        }

        double? res = null;

        try
        {
            res = a.Value / b.Value;
        }
        catch (NullReferenceException)
        {
            //Gestion de l'exception
        }
        finally
        {
            //Pour les ressources non managées qui doivent être nettoyées, pas gérées par .NET, s'aider de la documentation
            //Ne pas utiliser de bibliothèques sans documentation, utiliser des officielles
            //Le "Close" à écrire ici en cas de besoin
        }
  
        return res;
    }
}









                                                                                        // || \\
                                                                                       //  ||  \\
                                                                                      //   ||   \\
                                                                                     //    ||    \\
                                                                                    //     ||     \\
                                                                                   //      ||      \\
                                                                                  //       ||       \\
                                                                                 //        ||        \\
                                                                                //         ||         \\
                                                                               //          ||          \\
                                                                              //           ||           \\
                                                                             //            ||            \\
                                                                            //             ||             \\
                                                                           //              ||              \\
                                                                          //               ||               \\
                                                                         //                ||                \\
                                                                        //                 ||                 \\
                                                                       //                  ||                  \\
                                                                      //                   ||                   \\
                                                                     //                    ||                    \\
                                                                    //                     ||                     \\
                                                                   //                      ||                      \\