using System;
using System.Collections.Generic;


namespace WizardNerd
{
    public class Wizard : Human
    {
        public Wizard(string name) : base(name, 3, 25, 3, 50) { }

        public void heal()
        {
            health += 10 * intelligence;
        }

        public void fireballs(Human victim)
        {
            if (victim != null)
            {
                Random rand = new Random();
                int ballshot = rand.Next(25, 50);
                victim.health -= ballshot;
                Console.WriteLine($"FIREBALLS!!  Minus {ballshot} points!");
            }
        }

    }

}