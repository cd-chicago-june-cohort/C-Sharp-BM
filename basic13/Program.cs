using System;
using System.Collections.Generic;

namespace basic13
{
    class Program
    {

        // Print 1 to 255
        public static void print1to255() {
            Console.WriteLine("********************");
            for (byte i = 0; i < 255; i++) {
                Console.WriteLine(i+1);
            }
        }

        // Print 1 to 255 odd
        public static void print1to255odd() {
            Console.WriteLine("********************");
            for (byte i = 0; i < 255; i++) {
                if (i%2 == 0) {
                    Console.WriteLine(i+1);
                }
            }
        }

        // Print the sum of 1 to 255
        public static void printSum() {
            Console.WriteLine("********************");
            int sum = 0;
            for (int i = 0; i < 256; i++) {
                sum += i;
                Console.WriteLine("New number: " + i + " Sum: " + sum);
            }
        }

        // Iterate through an array
        public static void iterate(int[] arr) {
            Console.WriteLine("********************");
            for (int i = 0; i < arr.Length; i++) {
                Console.WriteLine(arr[i]);
            }
        }

        // Find the maximum value in array
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
        // Average of array
        public static void average(int[] arr) {
            Console.WriteLine("********************");
            
            int sum = 0;
            for (int i = 0; i < arr.Length; i++) {
                sum += arr[i];
            }
            int avg = sum/arr.Length;
            Console.WriteLine("The average is: " + avg);
        }

        // Array 255 of odds
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

         // Greater than Y
        public static int greaterThanY(int[] arr, int y){
            Console.WriteLine("********************");
            int counter = 0;
            for(var i = 0; i < arr.Length; i++){
                if(arr[i] > y){
                    counter += 1;
                }
            }
            return counter;
        }
        // Square the Values
        public static int[] squareVals(int[] arr){
            Console.WriteLine("********************");
            for(var k=0;k<arr.Length;k++){
                arr[k] = arr[k] * arr[k];
            }
            return arr;
        }
        // Eliminate Negative Numbers
        public static int[] noNegs(int[] arr){
            Console.WriteLine("********************");
            for(var i=0; i<arr.Length; i++){
                if(arr[i] < 0){
                    arr[i] = 0;
                }
            }
            foreach(int val in arr){
                Console.WriteLine(val);
            }
            return arr;
        }
        // Min, Max, and Average
        public static void minMaxAvg(int[] arr){
            Console.WriteLine("********************");
            int min = arr[0];
            int max = arr[0];
            int sum = arr[0];
            for(var i = 0; i <arr.Length; i++){
                if(arr[i] < min){
                    min = arr[i];
                }
                if(arr[i] > max){
                    max = arr[k];
                }
                sum += arr[i];
            }
            float avg = sum / arr.Length;
            Console.WriteLine("The min is: " + min.ToString());
            Console.WriteLine("The max is: " + max.ToString());
            Console.WriteLine("The avg is: " + avg.ToString());
        }
        // Shifting the values in an array
        public static void shiftArrayByOne(int[] arr){
            Console.WriteLine("********************");
            for(var i = 0; i <arr.Length; i++){
                if(i == (arr.Length-1)){
                    arr[i] = 0;
                }
                else{
                    arr[i] = arr[i+1];
                }
            }
            foreach(int arrVal in arr){
                Console.WriteLine(arrVal);
            }
        }
        // Number to String
        public static object[] numToString(int[] arr){
            Console.WriteLine("********************");
            List<object> newArr = new List<object>();
            for(var i = 0; i < arr.Length; i++){
                if(arr[i] < 0){
                    newArr.Add("Dojo");
                }
                else{
                    newArr.Add(arr[i]);
                }
            }
            return newArr.ToArray();
        }


        static void Main(string[] args) {
            Console.WriteLine("********************");
            print1to255();
            print1to255odd();
            printSum();

            int[] arr = {1,3,5,-7,9,-13};
            int y = 3;

            iterate(arr);
            findMax(arr);
            average(arr);
            oddArray();
            greaterThanY(arr, y);
            squareVals(arr);
            noNegs(arr);
            minMaxAvg(arr);
            shiftArrayByOne(arr);
            numToString(arr);

        }
    }
}
    
    
