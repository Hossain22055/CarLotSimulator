using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var lot = new CarLot();

            var car1 = new Car();
            car1.Make = "Honda";
            car1.Model = "Civic";
            car1.Year = 2020;
            car1.EngineNoie = "HOOOOOOOOOOOO";
            car1.HonkNoise = "BEEEEEEEEEEPPPPPPPP";
            car1.IsDriveable = true;

            lot.listofCars.Add(car1);

            Console.WriteLine();

            var hisCar = new Car();
            hisCar.Make = "Tesla";
            hisCar.Model = "Cyber Truck";
            hisCar.Year = 2020;
            hisCar.EngineNoie = "Moveeeeeeeeeeeeee";
            hisCar.HonkNoise = "Seeeeeeeeeeee";
            hisCar.IsDriveable = true;

            lot.listofCars.Add(hisCar);
            Console.WriteLine();


            var herCar = new Car();
            herCar.Make = "Toyota";
            herCar.Model = "S5";
            herCar.Year = 2020;
            herCar.EngineNoie = "BEPEPEPE";
            herCar.HonkNoise = "Sahahahaha";
            herCar.IsDriveable = false;

            lot.listofCars.Add(herCar);


            var mycar = new Car("Honda", "Civic", 2021, "beep", "ceep", true);

            lot.listofCars.Add(mycar);

          
            foreach( var car in lot.listofCars)
            {
                Console.WriteLine($"Year: {car.Year} Make: { car.Make}  Model: {car.Model}");
            }
            
        }
    }
}
