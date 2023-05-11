using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdsFlyingAroundApp
{
    // Eagle class inherits from FlyingBird
    public class Eagle : FlyingBird
    {
        public override void MakeSound()
        {
            Console.WriteLine("I'm an eagle! SQUAWK!");
        }
    }    
}

