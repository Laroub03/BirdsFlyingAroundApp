using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdsFlyingAroundApp
{
    // Base class for non-flying birds that implements the IBird interface
    public class NonFlyingBird : IBird
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("I'm a non-flying bird :(");
        }
    }
}
