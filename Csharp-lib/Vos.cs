using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_lib
{
    internal class Vos : Dier
    {
        public Vos(int gewicht) : base(gewicht)
        {
        }

        public override string Geluid()
        {
            return "snarl.mp3"; // Bestandsnaam voor het geluid
        }
    }
}