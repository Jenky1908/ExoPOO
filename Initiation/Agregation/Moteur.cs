using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Initiation.Agregation
{
    public class Moteur
    {
        public string Motorisation { get; private set; }

        public Moteur(string motorisation)
        {
            Motorisation = motorisation;
        }
    }
}
