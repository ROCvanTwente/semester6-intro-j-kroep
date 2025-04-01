﻿using System;

namespace Csharp_lib
{
    // Abstracte superklasse Dier
    public abstract class Dier
    {
        // Property voor gewicht
        public int Gewicht { get; set; }

        // Constructor
        public Dier(int gewicht)
        {
            Gewicht = gewicht;
        }

        // Abstracte methode voor geluid
        public abstract string Geluid();
    }
}