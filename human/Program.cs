using System;

namespace human
{
    class Program
    {
        static void Main(string[] args)
        {
           Human Joe = new Human ("Joe", 5, 5, 5, 100); 
           Console.WriteLine($"Joe has {Joe.strength} strength points {Joe.health} points.");

            Human Dan = new Human ("Dan", 10, 7, 8, 200); 
           Console.WriteLine($"Dan has {Dan.strength} strength points, and {Dan.health} points.");

           Joe.attack(Dan);
           Console.WriteLine($"Jealous of his health points, Joe fucking attacked Dan in broad daylight, leaving him with only {Dan.health} health points.");

        }
    }
}
