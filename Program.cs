using System;
using System.Collections.Generic;

namespace BirdsFlyingAroundApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of all birds
            List<IBird> birds = new List<IBird>
            {
                new Eagle(),
                new Falcon(),
                new Penguin(),
                new Ostrich()
            };

            // Create a list of flying birds
            List<IFlyable> flyingBirds = new List<IFlyable>
            {
                new Eagle(),
                new Falcon()
            };

            // Display all birds and their sounds
            Console.WriteLine("All birds:");
            foreach (var bird in birds)
            {
                bird.MakeSound();
            }

            // Display flying birds and their flying action
            Console.WriteLine("\nFlying birds:");
            foreach (var flyingBird in flyingBirds)
            {
                flyingBird.Fly();
            }
        }
    }
}
