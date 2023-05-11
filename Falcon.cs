using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdsFlyingAroundApp
{
    // Falcon class inherits from FlyingBird
    public class Falcon : FlyingBird
    {
        public override void MakeSound()
        {
            Console.WriteLine("I'm a falcon! SCREECH!");
        }
    }
}
