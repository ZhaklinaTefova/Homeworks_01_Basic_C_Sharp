namespace SwapNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Task 3
            
            Create new console application “SwapNumbers”. Input 2 numbers from the console and then swap the values of the variables 
            so that the first variable has the second value and the second variable the first value. Please find example below:

            Test Data:
                Input the First Number: 5
                Input the Second Number: 8
            Expected Output:
            After Swapping:
                First Number: 8
                Second Number: 5
            */

            Console.WriteLine("Please provide two numbers:");

            Console.WriteLine("\nInput your First Number:");
            string inputOne = Console.ReadLine();
            Console.WriteLine($"Your first number is {inputOne}.");

            Console.WriteLine("\nInput your Second Number:");
            string inputTwo = Console.ReadLine();
            Console.WriteLine($"Your second number is {inputTwo}.");

            bool converOne = int.TryParse(inputOne, out int numberOne);
            bool converTwo = int.TryParse(inputTwo, out int numberTwo);

            if (!converOne || !converTwo)
            {
                Console.WriteLine("Wrong input!");
            }

            int swipeHelper;

            swipeHelper = numberOne;
            numberOne = numberTwo;
            numberTwo = swipeHelper;

            Console.WriteLine("\nAfter swapping:");
            Console.WriteLine($"First number: {numberOne}");
            Console.WriteLine($"Second number: {numberTwo}");

        }
    }
}