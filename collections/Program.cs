using System;
using System.Collections.Generic;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr1 = {0,1,2,3,4,5,6,7,8,9};
                foreach(int num in arr1) {
                    Console.WriteLine(num);
                }
            
            string[] arr2 = { "Guadalupe", "LaDontrellique", "Joe", "Butterfly", "Chimpy" };
                foreach(string name in arr2) {
                    Console.WriteLine(name);
                    Console.WriteLine("*******************");
                }

            bool [] arr3 = new bool[10];
                for (int i = 0; i < arr3.Length; i++) {
                if(i%2 == 0) {
                    arr3[i] = true;
                } else {
                    arr3[i] = false;
                }

                } 
                
                foreach(bool boo in arr3) {
                        Console.WriteLine(boo);
                }


            for (int i = 1; i < 11; i++) {
                int[] arr4 = new int[10];
                for (int j = 1; j < 11; j++)
                {
                    arr4[j-1] = i * j;
                }
                Console.WriteLine("[" + string.Join(",", arr4) + "]");
            }

            // ICE CREAM FLAVORS!
            Console.WriteLine("*******************");
            List <string> flavors = new List <string> ();
            
            flavors.Add("Chicken");
            flavors.Add("Broccoli");
            flavors.Add("Scrambled Eggs");
            flavors.Add("Butter");
            flavors.Add("Sand");

            Console.WriteLine("We've got " + flavors.Count + " different ice cream flavors!");

            Console.WriteLine(flavors[2] + " flavor isn't selling well.");

            Console.WriteLine("Due to nastiness, we're discontinuing " + flavors[2] + " flavored ice cream. We apologize for any inconvenience.");
            flavors.RemoveAt(2);

            Console.WriteLine("Now there's " + flavors.Count + " different flavors!");


            // My Dictionary
            Console.WriteLine("*******************");
            Dictionary<string,string> names = new Dictionary<string,string>();

            for (int i = 0; i < arr2.Length; i++) {
                names.Add(arr2[i], null);
            }

            Random flavor = new Random();

            foreach (string name in arr2){
                names[name] = flavors[flavor.Next(0,4)];
            }

            foreach (KeyValuePair<string,string> entry in names){
                Console.WriteLine(entry.Key + " loves " + entry.Value + " flavored ice cream");
            }
        }
    }
}
