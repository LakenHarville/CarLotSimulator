﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    class Car
    {
        public int Year { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public string IsDriveable { get; set; }

        public void MakeEngineNoise()
        {
            Console.WriteLine($"The {Year} {Make} {Model} makes for a {EngineNoise} engine and is {IsDriveable}.");
        }
        public void MakeHonkNoise()
        {
            Console.WriteLine($"The {Year} {Make} {Model} also makes a {HonkNoise} honk that can be quite annoying.");
        }

    }
}