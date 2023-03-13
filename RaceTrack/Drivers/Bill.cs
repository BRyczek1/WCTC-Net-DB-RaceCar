using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RaceTrack.RaceTrack.Cars;

namespace RaceTrack.RaceTrack.Drivers
{
    public class Bill : Driver
    {
        public Bill(RaceCar car) : base(car)
        {
            Name = "Bill";
            SkillLevel = 15;
        }

        public override void Drive()
        {
            Car.Accelerate(SkillLevel);
        }

        public override void StopEngine()
        {
            Console.WriteLine($"The {Name} goes silent!");
        }

    }
}
