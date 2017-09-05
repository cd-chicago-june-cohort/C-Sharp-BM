using System;
using System.Collections.Generic;

namespace boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<object> things = new List<object>();

            things.Add(7);
            things.Add(28);
            things.Add(-1);
            things.Add(true);
            things.Add("chair");

            for (int i = 0; i < things.Count; i++) {
            Console.WriteLine(things[i]);
            }

            int sum = 0;
            foreach (var thing in things) {
            if (thing is int) {
                sum += (int)thing;
            }

            } Console.WriteLine(value: "The sum of the things is " + sum);
        }
    }
}
