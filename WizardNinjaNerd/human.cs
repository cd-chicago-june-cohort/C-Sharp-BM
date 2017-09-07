using System;

namespace WizardNerd
{
    public class Human
    {
        public string name;

        public int health { get; set; }
        public int strength { get; set; }
        public int intelligence { get; set; }
        public int dexterity { get; set; }

        public Human(string person)
        {
            name = person;
            strength = 3;
            intelligence = 3;
            dexterity = 3;
            health = 100;
        }
        public Human(string person, int str, int intel, int dex, int hp)
        {
            name = person;
            strength = str;
            intelligence = intel;
            dexterity = dex;
            health = hp;
        }
        public void attack(object obj)
        {
            Human victim = obj as Human;
            if (victim == null)
            {
                Console.WriteLine("Failed Attack");
            }
            else
            {
                victim.health -= strength * 5;
            }
        }
    }

}