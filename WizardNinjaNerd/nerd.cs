using System;
using System.Collections.Generic;

namespace WizardNerd {

    public class Nerd : Human {

        public static int nerdCount;

        public Nerd(string name) : base(name, 3, 3, 3, 200) {
            ++nerdCount;
         }

        public void death_blow(Human victim)
        {
            if (victim.health < 50) { 
            victim.health = 0;
            }
            Console.WriteLine($"DEATH BLOW!  As the name implies, you are now dead.");
        }

        public void meditate(Human Nerd)
        {
            Nerd.health = 200;
            Console.WriteLine($"The nerd has full health of {Nerd.health}, and will be reciting lines from 'Harry Potter' again in no time.");
        }

        public static int how_many() {
            return nerdCount;
        }
        }

    }


