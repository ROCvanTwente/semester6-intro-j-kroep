using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_lib
{
    internal class Koe : Dier
    {
        public Koe(int gewicht) : base(gewicht)
        {
        }

        public override string Geluid()
        {
            return "moe.mp3"; // Bestandsnaam voor het geluid
        }
    }
}