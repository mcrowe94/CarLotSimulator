using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            #region EXERCISE
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


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
            #endregion 

            var carLot = new List<Car>();

            var monisCar = new Car();
            monisCar.Make = "Chevy";
            monisCar.Model = "Equinox";
            monisCar.Year = 2016;
            monisCar.EngineNoise = "Vroom!!";
            monisCar.HonkNoise = "Beep beep!!";
            monisCar.IsDriveable = true;

            carLot.Add(monisCar);

            var snakesCar = new Car();
            snakesCar.Make = "Honda";
            snakesCar.Model = "Civic";
            snakesCar.Year = 2022;
            snakesCar.EngineNoise = "Nyoom!";
            snakesCar.HonkNoise = "Beep!!";
            snakesCar.IsDriveable = true;

            carLot.Add(snakesCar);

            var audreysCar = new Car();
            audreysCar.Make = "Little Tikes";
            audreysCar.Model = "Cozy Coupe";
            audreysCar.Year = 1979;
            audreysCar.EngineNoise = "*audible childs play noise*";
            audreysCar.HonkNoise = "HONK!!!";
            audreysCar.IsDriveable = false;

            carLot.Add(audreysCar);

            

            DisplayNoise(monisCar);
            Console.WriteLine("------------");
            DisplayNoise(snakesCar);
            Console.WriteLine("------------");
            DisplayNoise(audreysCar);
            Console.WriteLine("------------");

            foreach (var car in carLot)
            {
                Console.WriteLine($"{car.Year} {car.Make} {car.Model}");
            }
        }
        public static void DisplayNoise(CarLotSimulator.Car car)
        {
            Console.WriteLine($"The {car.Make} {car.Model}'s engine sounds like {car.EngineNoise} " +
                $"and the horn sounds like {car.HonkNoise}!");
        }
    }
    
}
