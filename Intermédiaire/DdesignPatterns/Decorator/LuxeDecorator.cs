using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Intermédiaire.DdesignPatterns.Decorator
{
    internal class LuxeDecorator : VoitureDecorator
    {
        public LuxeDecorator(IVoiture voiture) : base(voiture)
        {

        }

        public override void Assembler()
        {
            base.Assembler();
            Console.WriteLine("-- avec options de luxe $$$");
        }
    }
}
