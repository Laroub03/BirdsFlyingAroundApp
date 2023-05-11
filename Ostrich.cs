using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdsFlyingAroundApp
{
    // Ostrich class inherits from NonFlyingBird
    public class Ostrich : NonFlyingBird
    {
        public override void MakeSound()
        {
            Console.WriteLine("I'm an ostrich! BOOM!");
        }
    }
}
