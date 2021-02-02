using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    public class Car
    {
        public Car()
        {
        }
        public Car(string make, string model, int year, string enginenoise, string honknoise, bool isdriveable)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoie = enginenoise;
            HonkNoise = honknoise;
            IsDriveable = isdriveable;
        }

        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoie{ get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }


        public void MakeEngineNoise(string engineNoise)
        {
            Console.WriteLine(engineNoise);
        }

        public void MakeHonkNoise(string honkNoise)
        {
            Console.WriteLine(honkNoise);
        }















    }
}
