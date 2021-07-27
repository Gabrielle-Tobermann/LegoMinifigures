using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMinifigures.Heads
{
    // classes are implicitely internal => only accessible to the project it belongs to
    class ConstructionWorkerHead : HeadBase
    {
        public bool HasMulltet { get; set; }
        public int NumberOfTeeth { get; set; }
        public bool WearingHardHat { get; set; }

        public bool ToggleHatWearing()
        {
            WearingHardHat = !WearingHardHat;

            Console.WriteLine($"The Construction Worker Head {(WearingHardHat ? "is" : "is not")} wearing it's hard hat");
            return WearingHardHat;
        }

        public override void Spin()
        {
            if (NumberOfTeeth > 0)
             NumberOfTeeth -= 1;
            // If if statement block is only one line you don't need curly braces
            Console.WriteLine($"The {Color} Construction Worker Head spins after being hit by a girder.");
        }

        public void SayHi()
        {
            Console.WriteLine("The Construction Worker Head says hi.");
        }

        // enum are fixed options

    }
}
