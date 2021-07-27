using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMinifigures.Heads
{
    class AstronautHead : HeadBase
    {
        public  bool WearingHelmet { get; set; }
        public FacialHair FacialHair { get; set; }

        // override will override the sayHi method from the base class
        public override void SayHi()
        {
            // base.SayHi() will call the sayHi method defined in the base class
            base.SayHi();
            Console.WriteLine("Major Tom to Ground Control...");
        }

        public void Spin()
        {
            Console.WriteLine("The Astronaut head spins tto tsake in the beauty of the cosmos...");
        }

        public void Shave()
        {
            Console.WriteLine($"The Astronaut head sahves its {FacialHair}.");
            FacialHair = FacialHair.None;
        }
    }
}
