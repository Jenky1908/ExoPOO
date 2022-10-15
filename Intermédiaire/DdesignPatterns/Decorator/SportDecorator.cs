using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermédiaire.DdesignPatterns.Decorator
{
    internal class SportDecorator : VoitureDecorator
    {
        public SportDecorator(IVoiture voiture) : base(voiture)
        {

        }

        public override void Assembler()
        {
            base.Assembler();
            Console.WriteLine("-- avec options SPORT !!!");
        }
    }
}
