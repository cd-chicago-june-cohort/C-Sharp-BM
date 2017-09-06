using System;
using System.Collections.Generic;

namespace basic13
{
    class Program
    {
        public static void print1to255() {
            Console.WriteLine("********************");
            for (byte i = 0; i < 255; i++) {
                Console.WriteLine(i+1);
            }
        }
        public static void print1to255odd() {
            Console.WriteLine("********************");
            for (byte i = 0; i < 255; i++) {
                if (i%2 == 0) {
                    Console.WriteLine(i+1);
                }
            }
        }
        public static void printSum() {
            Console.WriteLine("********************");
            int sum = 0;
            for (int i = 0; i < 256; i++) {
                sum += i;
                Console.WriteLine("New number: " + i + " Sum: " + sum);
            }
        }

        public static void iterate(int[] arr) {
            Console.WriteLine("********************");
            for (int i = 0; i < arr.Length; i++) {
                Console.WriteLine(arr[i]);
            }
        }

        public static void findMax(int[] arr) {
            Console.WriteLine("********************");
            int max = 0;
            for (int i = 0; i < arr.Length; i++) {
                if (arr[i] > max) {
                     max = arr[i];
                }
            }
            Console.WriteLine("The max number is: " + max);
        }

        public static void average(int[] arr) {
            Console.WriteLine("********************");
            
            int sum = 0;
            for (int i = 0; i < arr.Length; i++) {
                sum += arr[i];
            }
            int avg = sum/arr.Length;
            Console.WriteLine("The average is: " + avg);
        }

        public static int[] oddArray() {
            Console.WriteLine("********************");
            
            List<int> y = new List<int>();
            for (byte i = 0; i < 255; i++) {
                if (i%2 == 0) {
                y.Add(item: i+1);
                }
            }
            return y.ToArray();;
        }

        public static int[] greaterThanY(int [] arr, int [] y) {
            Console.WriteLine("********************");
                for (int i = 0; i < arr.Length; i++) {
                    if (arr[i] > y) {
                        arr.Add(i)
                    }
                }




            


        static void Main(string[] args) {
            Console.WriteLine("********************");
            print1to255();
            print1to255odd();
            printSum();

            int[] arr = {1,3,5,-7,9,-13};

            iterate(arr);
            findMax(arr);
            average(arr);
            oddArray();
            
        }

    }
    
}
    
    
