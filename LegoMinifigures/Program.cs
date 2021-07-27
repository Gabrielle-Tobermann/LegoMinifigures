using LegoMinifigures.Heads;
using System;
using System.Collections.Generic;

namespace LegoMinifigures
{
    class Program
    {
        static void Main(string[] args)
        {
            var workerHead = new ConstructionWorkerHead();

            workerHead.Color = LegoColor.Yellow;

            var batmanHead = new BatmanHead();

            var astronautHead = new BatmanHead();

            var heads = new List<HeadBase>() { astronautHead, batmanHead, workerHead };

            // Because all the classes that inherit from HeadBase has a method for sayHi ans Spin,
            // they can be called like this
            foreach (var head in heads)
            {
                head.SayHi();
                head.Spin();
            }
        }
    }
}
