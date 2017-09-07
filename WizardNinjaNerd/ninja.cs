using System;
using System.Collections.Generic;


namespace WizardNerd
{
    public class Ninja : Human
    {
        public Ninja(string name) : base(name, 3, 3, 175, 100) { }

        public void heal()
        {
            health += 10 * intelligence;
        }

        public void steal(Human Ninja)
        {
            Ninja.health += 10;
            Console.WriteLine($"STOP, THIEF!!  Ninja now has {Ninja.health} health points!");
        }

        public void get_away(Human Ninja)
        {
            Ninja.health -= 15;
            Console.WriteLine($"RUN AWAY! Ninja now has {Ninja.health} health points.");
        }

    }

}