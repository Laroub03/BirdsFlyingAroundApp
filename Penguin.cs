using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdsFlyingAroundApp
{
    // Penguin class inherits from NonFlyingBird
    public class Penguin : NonFlyingBird
    {
        public override void MakeSound()
        {
            Console.WriteLine("I'm a penguin! HONK!");
        }
    }
}
