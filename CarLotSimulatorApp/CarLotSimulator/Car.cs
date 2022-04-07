using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    public class Car
    {
       

        public int Year { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; } 

        public Car()
        {
            CarLot.numberOfCars++; 
        }

        public Car(int year, string model, string make, string enginenoise, string honknoise, bool IsDriveable = false)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = enginenoise;
            HonkNoise = honknoise;
        }

        public void MakeEngineNoise()
        {
            Console.WriteLine($"The {Year} {Make} {Model} makes for a {EngineNoise} engine.");
        }
        public void MakeHonkNoise()
        {
            Console.WriteLine($"The {Year} {Make} {Model} also makes a {HonkNoise} honk that can be quite annoying.");
        }

    }
}
