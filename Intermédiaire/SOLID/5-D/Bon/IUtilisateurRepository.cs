using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermédiaire.SOLID._5_D.Bon
{
    internal interface IUtilisateurRepository
    {
        internal Utilisateur FindById(long id);
    }
}
