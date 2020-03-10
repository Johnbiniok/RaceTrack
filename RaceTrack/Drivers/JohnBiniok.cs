using System;
using RaceTrack.RaceTrack.Cars;

namespace RaceTrack.RaceTrack.Drivers
{
    public class JohnBiniok : Driver
    {
        public JohnBiniok(RaceCar car) : base(car)
        {
            Name = "John Biniok";
            SkillLevel = 10;
        }

        public override void Drive()
        {
            Car.Accelerate(SkillLevel);
        }
        public override void StopEngine()
        {
            Console.WriteLine($"{Name} was happy with his performance as he shut his engine down.");
        }
    }
}