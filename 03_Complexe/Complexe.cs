using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Complexe
{
    public class Complexe
    {
        public int PartiReel { get; set; }

        public int PartiImaginaire { get; set; }

        public Complexe()
        {

        }

        public Complexe(int partiReel, int partiImaginaire)
        {
            PartiReel = partiReel;
            PartiImaginaire = partiImaginaire;
        }

        public override string ToString()
        {
            return $"Le nombre est ({PartiReel}, {PartiImaginaire})";
        }
            
        

        public double GetMagnitude()
        {
            return Math.Sqrt(Math.Pow(PartiReel, 2) + Math.Pow(PartiImaginaire, 2));
        }

        public static string Sum(Complexe c1, Complexe c2)
        {
            return $"Après l'addition : ({c1.PartiReel + c2.PartiReel}, {c1.PartiImaginaire + c2.PartiImaginaire})";
        }
    }
}
