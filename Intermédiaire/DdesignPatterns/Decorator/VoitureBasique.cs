﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermédiaire.DdesignPatterns.Decorator
{
    internal class VoitureBasique : IVoiture
    {
        public void Assembler()
        {
            Console.WriteLine("Voiture basique...");
        }
    }
}
