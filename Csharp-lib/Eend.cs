using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_lib
{
    internal class Eend : Dier
    {
        public Eend(int gewicht) : base(gewicht)
        {
        }

        public override string Geluid()
        {
            return "quack.mp3"; // Bestandsnaam voor het geluid
        }
    }
}