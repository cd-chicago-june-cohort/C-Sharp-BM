using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        
        {
            for (int i = 1; i < 255; i++) {
                Console.WriteLine(i);
            }

            Console.WriteLine("************************");
            for (int j = 1; j <= 100; j++) {
                if (j%3 == 0  && j%5 == 0) {
                    Console.WriteLine(j + "FizzBuzz");
                } else if (j%3 == 0) {
                    Console.WriteLine(j + "Fizz");
                } else if (j%5 == 0) {
                    Console.WriteLine(j + "Buzz");
                } 
            }

            Random rand = new Random();
                Console.WriteLine("************************");
                for(int val = 0; val < 10; val++) {
                //Prints the next random value between 2 and 8
                int n = (rand.Next(1,100));
                if (n%3 == 0 && n%5 == 0) {
                    Console.WriteLine(n + "FizzBuzz");
                } else if (n%3 == 0) {
                    Console.WriteLine(n + "Fizz");
                } else if (n%5 == 0) {
                    Console.WriteLine(n + "Buzz");
                }
            }
        }
    }
}
