using System;

namespace WizardNerd
{
    class Program
    {
        static void Main(string[] args)
        {
            Human Joe = new Human("Joe", 5, 5, 5, 40);
            Console.WriteLine($"Joe has {Joe.strength} strength points {Joe.health} points.");

            Human Dan = new Human("Dan", 10, 7, 8, 200);
            Console.WriteLine($"Dan has {Dan.strength} strength points, and {Dan.health} points.");

            Joe.attack(Dan);
            Console.WriteLine($"Jealous of his health points, Joe fucking attacked Dan in broad daylight, leaving him with only {Dan.health} health points.");

            Wizard Carl = new Wizard("Carl");
            Console.WriteLine("Looks like there's a new wizard in town, nerds!");

            Carl.fireballs(Dan);
            Console.WriteLine($"Wizard waved his nerd wand, and poor Dan only has {Dan.health} health points now.");

            Ninja Dave = new Ninja("Dave");
            Console.WriteLine("New Ninja, Please!");

            Dave.steal(Dave);
            Console.WriteLine("Watch your wallet around the Ninja.");

            Dave.get_away(Dave);
            Console.WriteLine("The Ninja got away.  This time..");

            Nerd Newt = new Nerd("Newt");
            Console.WriteLine("New Nerd Alert.");

            Newt.death_blow(Joe);
            Console.WriteLine("Newt blew Joe with a dirty Death Blow.");

            Newt.meditate(Newt);
            Console.WriteLine("Newt meditated and got his light sabre working again.");

            Nerd Nelly = new Nerd("Nelly");

            Nerd.how_many();
            Console.WriteLine($"There are now {Nerd.nerdCount} nerds.");
        }
    }
}
