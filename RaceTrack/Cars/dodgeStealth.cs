using System;

namespace RaceTrack.RaceTrack.Cars
{
    public class dodgeStealth : RaceCar
    {
        public dodgeStealth()
        {
            Name = "Dodge Stealth";
            TopSpeed = 130;
        }
        public override void StartEngine()
        {
            Console.WriteLine($"The {Name} screams as it starts!");
        }

        public override void Brake()
        {
            Console.WriteLine($"The {Name} stops on a dime!");
            base.Brake();
        }
    }

}