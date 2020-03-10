using RaceTrack.RaceTrack.Cars;

namespace RaceTrack.RaceTrack.Drivers
{
    public class JohnBiniok : Driver
    {
        public JohnBiniok(RaceCar car) : base(car)
        {
            Name = "John Biniok";
            SkillLevel = 6;
        }

        public override void Drive()
        {
            Car.Accelerate(SkillLevel);
        }
    }
}