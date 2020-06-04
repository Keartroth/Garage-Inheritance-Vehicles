using System;

namespace Inheritance_Vehicles
{
    public class Zero : Vehicle // Electric motorcycle
    {
        public double BatteryKWh { get; set; }
        public void ChargeBattery()
        {
            // method definition omitted
        }
        public override void Drive()
        {
            Console.WriteLine($"The {this.MainColor} Zero zips by you. Yeeeeoooooow!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The bike quickly swerves {direction}.");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {this.MainColor} bike quickly squeals to a stop!");
        }
    }
}