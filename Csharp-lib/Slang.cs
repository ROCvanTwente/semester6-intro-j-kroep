﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_lib
{
    internal class Slang : Dier
    {
        public Slang(int gewicht) : base(gewicht)
        {
        }

        public override string Geluid()
        {
            return "his.mp3"; // Bestandsnaam voor het geluid
        }
    }
}