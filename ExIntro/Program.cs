using System;

namespace Exercices
{
    internal class CSInter
    {
        static void Main(string[] args)
        {
            int[] tab1 = { 10, 0, 20, 15 };
            int a1 = 10;
            int b1 = 20;

            //1 : Créer une méthode "Somme" qui retourne la somme de 2 etniers

            /*2 : Créer 2 méthodes "Afficher" (surcharge) :
             *      a : Afficher un texte
             *      b : Afficher un élément de tab1
             */

            //3 : Créer une surcharge de la méthode "Somme" qui retourne la somme des éléments dans tab1

            //4 : Créer une méthode "Min" qui retourne l'élément le plus petit de tab1

            //5 : Créer une méthode "Moy" qui retourne la moyenne des élément de tab1

            /*6 : Créer une méthode "Calculer" qui prend 1 tableau en entrée (tab1) et qui calcule 2 valeur : la somme et le minimum
             *      Ces valeurs devront être passés via des paramètres de sortie
             */

            Console.WriteLine($"La somme vaut : {Somme(a1, b1)}");

            Afficher("Bonjour à toutes et à tous...");

            Console.WriteLine($"Voici tous les éléments de tab1 : ");
            Afficher(tab1);

            Console.WriteLine($"La somme des élément de tab1 est : {Somme(tab1)}");

            Console.WriteLine($"Le plsu petit nombre de tab1 est : {Min(tab1)}");

            Console.WriteLine($"La moyenne des élément de tab1 est : {Moy(tab1)}");

            Calculer(tab1, out int somme, out int min);

            Console.WriteLine($"La somme vaut : {somme} , et le minimum vaut {min}");

        }

        //1er question :

        public static int Somme(int a, int b)
        {
            return a + b;
        }



        //2e question : 1er surchagre

        public static void Afficher(string text)
        {
            Console.WriteLine(text);
        }

        //2e surcharge

        public static void Afficher(int[] tab)
        {
            foreach (var nombre in tab)
            {
                Console.WriteLine(nombre);
            }
        }



        //3e question :

        public static int Somme(int[] tab)
        {
            int somme = 0;
            foreach (var nombre in tab)
            {
                somme += nombre;
            }
            return somme;
        }



        //4e question :

        public static int Min(int[] tab)
        {
            int min = tab[0];
            for (int i = 1; i < tab.Length; ++i)
            {
                var nombre = tab[i];
                 
                if (nombre < min)
                {
                    min = nombre;
                }
            }
            return min;

            
            //int min = tab[0]
            //int i = 1
            //while (i < tab.Length)
            //{
            //    if(min>tab[i++])
            //    {
            //        min = tab[i - 1];
            //    }               
            //}
            //return min;
        }



        //5e question :

        public static double Moy(int[] tab)
        {
            return Somme(tab) / (double)tab.Length; //Bien caster l'un des opérande, sinon l'opération va "supprimer" les chiffres après la virgule
                                                    //car l'opération renvoie un int, et non un double
        }



        //6e question :

        public static void Calculer(int[] tab, out int somme, out int min)
        {
            somme = Somme(tab);
            min = Min(tab);
        }
    }
}
