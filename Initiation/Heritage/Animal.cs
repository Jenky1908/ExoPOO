using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Initiation.Heritage
{
    public abstract class Animal //Je ne peux pas créer de méthode abstraite si la classe n'est pas abstraite elle-même
    {
        public enum CouleurPelage
        {
            Marron,
            Noir,
            Blanc = 3,
            Sable
        }

        public string Nom { get; set; }

        public int Age { get; set; }

        public CouleurPelage Pelage { get; set; }

        public Animal(string nom, int age)
        {
            Nom = nom;
            Age = age;
        }

        public string GetInfos()
        {
            return $"Nom : {Nom}, Age : {Age}, Pelage : {Pelage}";
        }

        public virtual void Espece() //Comportement par défaut : Je suis un animal
        {
            Console.WriteLine("Je suis un animal");
        }

        public abstract void Deplacer(); //"abstract" oblige à redéfinir la méthode dans les classes enfants
    }
}
