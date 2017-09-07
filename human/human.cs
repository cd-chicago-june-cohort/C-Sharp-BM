using System;

namespace human
{
    public class Human 
    {
        public string name = "La-Ja'Ront'ay";
        public int strength = 3;
        public int intelligence = 3;
        public int dexterity = 3;
        public int health = 100;

        public Human(string nameInput, int strengthInput, int intelInput, int dexInput, int healthInput) {
            name = nameInput;
            strength = strengthInput;
            intelligence = intelInput;
            dexterity = dexInput;
            health = healthInput;
        }

        public void attack(object humanInput){
            if(humanInput is Human){
                Human ExplicitHuman = humanInput as Human;
                ExplicitHuman.health -= (5 * strength);
            }
            else{
                Console.WriteLine("INPUT MUST BE OF TYPE HUMAN TO ATTACK!");
            }
        }

    }
}