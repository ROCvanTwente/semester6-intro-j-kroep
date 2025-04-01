using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_lib
{
    internal class Schaap : Dier
    {
        public Schaap(int gewicht) : base(gewicht)
        {
        }

        public override string Geluid()
        {
            return "meh.mp3"; // Bestandsnaam voor het geluid
        }
    }
}