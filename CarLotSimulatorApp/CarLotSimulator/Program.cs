using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property

            var Toyota = new Car();
            Toyota.Make = "Toyota";
            Toyota.Model = "Camry";
            Toyota.Year = 2003;
            Toyota.EngineNoise = "quiet";
            Toyota.HonkNoise = "high pitch";
            Toyota.IsDriveable = "very easy to handle";
            Toyota.MakeEngineNoise();
            Toyota.MakeHonkNoise();

            Console.WriteLine("-------------------------");

            var Honda = new Car();
            Honda.Make = "Honda";
            Honda.Model = "Civic";
            Honda.Year = 2008;
            Honda.EngineNoise = "super quiet";
            Honda.HonkNoise = "high pitch";
            Honda.IsDriveable = "fairly easy to handle";
            Honda.MakeEngineNoise();
            Honda.MakeHonkNoise();

            Console.WriteLine("-------------------------");

            var Subaru = new Car();
            Subaru.Make = "Subaru";
            Subaru.Model = "Outback";
            Subaru.Year = 2015;
            Subaru.EngineNoise = "far too loud";
            Subaru.HonkNoise = "super loud";
            Subaru.IsDriveable = "way too powerful to handle it with ease";
            Subaru.MakeEngineNoise();
            Subaru.MakeHonkNoise();

            Console.WriteLine("-------------------------");

            var Ferrari = new Car();
            Ferrari.Make = "Ferrari";
            Ferrari.Model = "812 Competizione";
            Ferrari.Year = 2022;
            Ferrari.EngineNoise = "ear drum shattering loud";
            Ferrari.HonkNoise = "high pitch";
            Ferrari.IsDriveable = "not driveable for the average person because it has far too much horsepower";
            Ferrari.MakeEngineNoise();
            Ferrari.MakeHonkNoise();

            //Now that the Car class is created we can instanciate 3 new cars

            //Set the properties for each of the cars

            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
