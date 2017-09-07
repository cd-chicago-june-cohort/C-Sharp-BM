using System;

namespace human
{
    class Program
    {
        static void Main(string[] args)
        {
           Human Joe = new Human ("Joe", 5, 5, 5, 100); 
           Console.WriteLine($"Joe has {Joe.strength} strength points.");

            Human Dan = new Human ("Dan", 10, 7, 8, 100); 
           Console.WriteLine($"Dan has {Dan.strength} strength points.");

           Joe.attack(Dan);
           Console.WriteLine("Joe fucking attacked Dan.");

        }
    }
}
