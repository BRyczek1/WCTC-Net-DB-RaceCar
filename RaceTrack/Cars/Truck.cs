using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Cars
{
    public class Truck : RaceCar
    {
        public Truck()
        {
            Name = "Truck";
            TopSpeed = 85;
        }

        public override void StartEngine()
        {
            Console.WriteLine($"The {Name} is heating up!");
        }

        public override void Brake()
        {
            Console.WriteLine($"The {Name} Screaches to a halt!");
            base.Brake();
        }
    }
}
