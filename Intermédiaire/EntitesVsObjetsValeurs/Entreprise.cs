using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermédiaire.EntitesVsObjetsValeurs
{
    internal class Entreprise : IComparable<Entreprise>
    {
        public int? Id { get; set; } //Propriété avec Id nullable, car on peut demander une génération automatique par la base de données

        public string Nom { get; set; }

        public Geolocation Localisation { get; set; }

        public Entreprise(int? id, string nom, Geolocation localisation)
        {
            Id = id;
            Nom = nom;
            Localisation = localisation;
        }

        public int CompareTo(Entreprise other)
        {
            return Nom.CompareTo(other.Nom);
        }

        public int CompareToLocalisation(Entreprise e)
        {
            return Localisation.CompareTo(e.Localisation);
        }

        public override bool Equals(object obj) //Overrider Equals -> overrider GetHashCode
        {
            return obj is Entreprise e    //Je demande si obj est une entreprise et en même temps je le cast en Entreprise dans la variable e
                && Id == e.Id; 
        }

        public override int GetHashCode() //Sert aux algo pour retrouver plus vite un élément, pour insérer et identifier un objet (Le HashCode)
        {
            return 2108858624 + Id.GetHashCode();
        }
    }
}
