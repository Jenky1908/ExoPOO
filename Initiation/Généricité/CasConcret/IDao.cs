using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Initiation.Généricité.CasConcret
{
    //On met juste T en général, mais sinon on peut mettre autre chose mais précédé d'un T
    public interface IDao<TEntite, TCle> where TEntite : EntiteBase<TCle> // || \\ new() //constructeur public
    {
        TEntite GetById(TCle id);

        int Insert(TEntite entite);
    }                             
}                                
                                