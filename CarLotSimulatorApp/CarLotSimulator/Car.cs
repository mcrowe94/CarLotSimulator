using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    public class Car
    {
      public Car()
        {
            CarLot.numberOfCars++;
        }

        public Car(string make, string model, int year, string engine, string honk, bool drive)
        {
            Make = make;
            Model = model;
            Year = year;
            EngineNoise = engine;
            HonkNoise = honk;
            IsDriveable = drive;
        }

        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        public static string MakeEngineNoise(string engineNoise)
        {
            return engineNoise;
        }
        public static string MakeHonkNoise(string honkNoise)
        {
            return honkNoise;
        }
       
    }
}
