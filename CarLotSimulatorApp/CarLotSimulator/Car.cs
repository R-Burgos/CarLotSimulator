using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class Car
    {
        public Car()
        {
        }
        //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable - DONE
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise() - DONE
        //The methods should take one string parameter: the respective noise property - DONE
        public void MakeEngineNoise(string engineNoise)
        {
            Console.WriteLine($"This {Year} {Make} {Model} engine is {engineNoise}.");
        }
        public void MakeHonkNoise(string honkNoise)
        {
            Console.WriteLine($"This {Year} {Make} {Model} horn makes a {honkNoise} sound.");          
        }

        public string CanIDriveIt(bool isDriveable)
        {
           return (isDriveable == true) ? $"This car is driveable!" : $"Sorry, this car does not run.";
        }


        //Custom Constructor
        public Car(int year, string make, string model, string engineNoise, string honkNoise, bool isDriveable)
        {
            Year = year;
            Make = make; 
            Model = model; 
            EngineNoise = engineNoise;
            HonkNoise = honkNoise; 
            IsDriveable = isDriveable;
        }

































    }
}
