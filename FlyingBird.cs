using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdsFlyingAroundApp
{
    // Define the interface for all birds
    public interface IBird
    {
        void MakeSound();
    }

    // Define the interface for birds that can fly
    public interface IFlyable
    {
        void Fly();
    }

    // Base class for flying birds that implements both IBird and IFlyable interfaces
    public class FlyingBird : IBird, IFlyable
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("I'm a flying bird :)");
        }

        public virtual void Fly()
        {
            Console.WriteLine($"{GetType().Name} is flying!");
        }
    }

}
