using System;

namespace Csharp_lib
{
    // Subklasse Hond
    public class Hond : Dier
    {
        public Hond(int gewicht) : base(gewicht)
        {
        }

        public override string Geluid()
        {
            return "woef.mp3"; // Bestandsnaam voor het geluid
        }
    }
}