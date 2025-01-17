﻿using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var carLot = new CarLot();

            //TODO

            //Create a seperate class file called Car - DONE
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable - DONE
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise() - DONE
            //The methods should take one string parameter: the respective noise property - DONE

            //Now that the Car class is created we can instanciate 3 new cars - DONE
            //Set the properties for each of the cars - DONE
            //Call each of the methods for each car - DONE

            var car1 = new Car() // Object Initializer Syntax
            {
                Year = 2022,
                Make = "Toyota",
                Model = "Camry",
                EngineNoise = "quiet",
                HonkNoise = "low beep",
                IsDriveable = true
            };

            carLot.CarList.Add(car1); // Adding car1 to carList
            CarLot.numOfCars = carLot.CarList.Count;
            Console.WriteLine($"{CarLot.numOfCars} car in the car lot. It is a {car1.Make} {car1.Model}.");


            var car2 = new Car(); // Dot Notation
            car2.Year = 2017;
            car2.Make = "Nissan";
            car2.Model = "Altima";
            car2.EngineNoise = "quiet";
            car2.HonkNoise = "medium beep";
            car2.IsDriveable = false;

            carLot.CarList.Add(car2); // Adding car2 to carList
            CarLot.numOfCars = carLot.CarList.Count;
            Console.WriteLine($"{CarLot.numOfCars} cars in the car lot. This car is a {car2.Make} {car2.Model}.");

            var car3 = new Car(2018, "Jeep", "Compass", "loud", "loud beep", true); // Custom Constructor

            carLot.CarList.Add(car3); // Adding car3 to carList
            CarLot.numOfCars = carLot.CarList.Count;
            Console.WriteLine($"{CarLot.numOfCars} cars in the car lot. This last car is a {car3.Make} {car3.Model}.\n");

            //Calling Methods
            car1.MakeEngineNoise(car1.EngineNoise);
            car1.MakeHonkNoise(car1.HonkNoise);
           // Console.Beep(200, 400);
            Console.WriteLine(car1.CanIDriveIt(car1.IsDriveable));
            Console.WriteLine(" ");
            car2.MakeEngineNoise(car2.EngineNoise);
            car2.MakeHonkNoise(car2.HonkNoise);
           // Console.Beep(400, 400);
            Console.WriteLine(car2.CanIDriveIt(car2.IsDriveable));
            Console.WriteLine(" ");
            car3.MakeEngineNoise(car3.EngineNoise);
            car3.MakeHonkNoise(car3.HonkNoise);
          //  Console.Beep(1000, 1000);
            Console.WriteLine(car3.CanIDriveIt(car3.IsDriveable));
            Console.WriteLine(" ");

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car - DONE

            //*************BONUS X 2*************//

            //Create a CarLot class - DONE
            //It should have at least one property: a List of cars - DONE
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list. - DONE
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console - DONE

            foreach (var car in carLot.CarList)
            {
                Console.WriteLine($"---------------------");
                Console.WriteLine($"Year: {car.Year}\nMake: {car.Make}\nModel: {car.Model}\nEngine Noise: {car.EngineNoise}\nHorn Sound: {car.HonkNoise}");
                Console.WriteLine($"---------------------\n");
            }
        }        
    }
}
