namespace AverageNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
            Task 2
            
            Create new console application “AverageNumber” that takes four numbers as input to calculate and print the average.

            Test Data:
                Enter the First number: 10
                Enter the Second number: 15
                Enter the third number: 20
                Enter the four number: 30

                Expected Output:
                The average of 10, 15, 20 and 30 is: 18
            */

            Console.WriteLine("Please provide four numbers!");

            string inputOne = Console.ReadLine();
            string inputTwo = Console.ReadLine();
            string inputThree = Console.ReadLine();
            string inputFour = Console.ReadLine();

            bool convertOne = int.TryParse(inputOne, out int numberOne);
            bool convertTwo = int.TryParse(inputTwo, out int numberTwo);
            bool convertThree = int.TryParse(inputThree, out int numberThree);
            bool convertFour = int.TryParse(inputFour, out int numberFour);


            if (!convertOne || !convertTwo || !convertThree || !convertFour)
            {
                Console.WriteLine("Sorry, Wrong input!");
                return;
            }

            int additionResult = numberOne + numberTwo + numberThree + numberFour;
            int result = additionResult / 4;
            Console.WriteLine($"The average of {numberOne}, {numberTwo}, {numberThree} and {numberFour} is: {result}.");
        }
    }
}