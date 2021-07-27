using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMinifigures.Heads
{
    // This class inherits from Headbase, in which we defined the color. 
    class BatmanHead : HeadBase
    {
        public bool IsWearingMask { get; set; }
        public string Version { get; set; }
        public string FacialExpression { get; set; } = "Stoic";
        public void Spin()
        {
            Console.WriteLine("Where is the joker?!?!");
        }

        public BatmanHead()
        {
            Color = LegoColor.Black;
        }
        public override void SayHi()
        {
            Console.WriteLine("I'm Batman!");
        }


    }
}
