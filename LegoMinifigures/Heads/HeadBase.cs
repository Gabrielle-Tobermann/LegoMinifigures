using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMinifigures.Heads
{
    // abstract means this class is not meant to be instantiated. It's only purpose is for other classes to inherit from it.
    abstract class HeadBase
    {
        public LegoColor Color { get; set; }

        // virtual => this method behavior can be changed by classes that inherits from this class
        public virtual void SayHi()
        {
            Console.WriteLine("Hi.");
        }

        public abstract void Spin();
        // every class that inherits from HeadBase HAS to have a Spin() method, regardless of what the method does.
        // You still have to use the override kw in the inherited class. 
    }
}
