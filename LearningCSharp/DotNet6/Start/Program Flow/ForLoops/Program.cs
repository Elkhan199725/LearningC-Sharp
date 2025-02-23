using System;

namespace ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int myVal = 15;
            int[] nums = new int[] {3, 14, 15, 92, 6};
            string str = "The quick brown fox jumps over the lazy dog";

            // TODO: the basic for loop
            Console.WriteLine("The basic for loop:");
            for(int i = 0; i < myVal; i++){ // initialize i to 0, loop while i is less than myVal, increment i by 1 each iteration
                System.Console.WriteLine($"i is currently {i}");
            }

            Console.WriteLine("The for loop with an array:");
            for(int i = 0; i < nums.Length; i++){ // iterate over each element in the array
                System.Console.WriteLine($"nums[{i}] is currently {nums[i]}");
            }

            // TODO: the foreach-in loop can be used to iterate over sequences
            Console.WriteLine("The foreach loop:");
            foreach(int num in nums){ // iterate over each element in the array
                System.Console.WriteLine($"num is currently {num}");
            }

            // TODO: count the number of o's in the string
            char target = 'o';
            int count = 0;
            foreach(char c in str){ // iterate over each character in the string
                if(c == target){
                    count++; // increment the count if the character matches the target
                }
            }
            System.Console.WriteLine($"The number of {target}'s in the string is {count}");
        }
    }
}
