using Initiation.Généricité;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Initiation.Polymorphisme
{
    public class PolyTest
    {
        //ad-hoc (ou niveau de fonction avec des GetType) :
        //A ne pas utiliser !

        public static void Acheter(Object obj)
        {
            if (obj.GetType().Equals(typeof(Table))) // || \\ == if (obj is Table)
            {
                var table = (Table)obj;
                table.Plier();
            }

            //même chose pour Chaise
        }


        //Par sous-typage : 

        public static void Acheter(IPliable p)
        {
            p.Plier();
        }


        //Par types paramétriques

        public static void Acheter<T>(T pliable) where T : IPliable
        {
            pliable.Plier();
        }
    }
}
