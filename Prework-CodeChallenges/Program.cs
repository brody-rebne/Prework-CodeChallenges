using System;

namespace Prework_CodeChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing challenges...");
            //Challenge1();
            //Challenge2();
            //Challenge3();
            Challenge4();
        }

        public static void Challenge1() {
            //creating input array from user input
            int arrayLength = 5;
            int[] inputArray = new int[arrayLength];
            for(int i = 0; i < arrayLength; i++) {
                Console.WriteLine("Please enter a number between 1 and 10...");
                inputArray[i] = int.Parse(Console.ReadLine());
            }

            //get number to check for from user input
            Console.WriteLine("Enter the number to check for");
            int numInput = int.Parse(Console.ReadLine());

            //check array for number and add to return var
            int returnVar = 0;
            for(int j = 0; j < arrayLength; j++) {
                if(inputArray[j] == numInput) {
                    returnVar += numInput;
                }
            }

            //return
            Console.WriteLine($"You scored {returnVar}!");
        }

        public static void Challenge2() {
            //input and tracker
            Console.WriteLine("Please input a year...");
            int inputYear = int.Parse(Console.ReadLine());
            bool leapCheck = false;

            //check for /400 (always leap)
            if (inputYear % 400 == 0)
            {
                leapCheck = true;
            }

            //check for /4 but not /100
            else if (inputYear % 4 == 0 && inputYear % 100 != 0)
            {
                leapCheck = true;
            }

            //dumb if/else to write line
            if(leapCheck == true)
            {
                Console.WriteLine("That is a leap year");
            }
            else
            {
                Console.WriteLine("That is not a leap year");
            }
        }

        public static void Challenge3()
        {
            //creating user-input array again
            Console.WriteLine("How many numbers are in your sequence?");
            int arrayLength = int.Parse(Console.ReadLine());
            int[] inputArray = new int[arrayLength];
            for (int i = 0; i < arrayLength; i++)
            {
                Console.WriteLine("Please enter a number for your sequence...");
                inputArray[i] = int.Parse(Console.ReadLine());
            }

            //checkers
            int arraySum = 0;
            int arrayProd = 1;

            //ok here it is, gang
            foreach (int num in inputArray)
            {
                arraySum += num;
                arrayProd += num;
            }

            //ok checking now
            if(arraySum > 0 && arraySum == arrayProd)
            {
                Console.WriteLine("That is a perfect sequence!");
            }
            else
            {
                Console.WriteLine("That is not a perfect sequence.");
            }
        }

        public static int[] Challenge4()
        {
            //not getting this from user input
            int[,] inputArray = new int[3, 5] { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 } };
            int[] outputArray = new int[inputArray.GetLength(0)];
            for (int i=0; i<inputArray.GetLength(0); i++)
            {
                for (int j=0; j<inputArray.GetLength(1); j++)
                {
                    outputArray[i] += inputArray[i, j];
                }
            }
            Console.WriteLine($"[{string.Join(", ", outputArray)}]");
            return outputArray;
        }
    }
}
