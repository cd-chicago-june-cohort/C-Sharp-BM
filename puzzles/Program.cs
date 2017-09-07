using System;

namespace puzzles
{
    
    class Program
    {

        
        public static int [] random(){
            int [] arr = new int [10];
            Random randNum = new Random();
            int min = 0;
            int max = 0;
            int sum = 0;
            int ave = sum/arr.Length;

            for (int i = 0; i < arr.Length; i++) {
                arr[i] = randNum.Next(5,25);
                if (i==0){
                    min = arr[i];
                }
                if (arr[i]>max){
                    max = arr[i];
                }
                if (arr[i]<min){
                    min = arr[i];
                }
                sum += arr[i];
                Console.WriteLine("Number: {0}, {1}", i, arr[i]);
            }
            Console.WriteLine("Max: {0}, Min: {1}, Avg: {2}", max, min, ave);
            return arr;
            }







        static void Main(string[] args)
        {
            random();
        }
    }




}
