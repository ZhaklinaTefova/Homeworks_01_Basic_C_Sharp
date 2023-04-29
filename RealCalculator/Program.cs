namespace RealCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Task 1

            Create new console application “RealCalculator” that takes two numbers from the input and 
            asks what operation would the user want to be done ( +, - , * , / ). Then it returns the result.

                Test Data:
                    Enter the First number: 10
                    Enter the Second number: 15
                    Enter the Operation: +
                Expected Output:
                    The result is: 25
            */

            Console.WriteLine("Please insert your first number!");
            string inputNumOne = Console.ReadLine();
            if (!int.TryParse(inputNumOne, out int numOne))
            {
                Console.WriteLine("Incorect input!");
                return;
            }


            Console.WriteLine("Please insert your second number!");
            string inputNumTwo = Console.ReadLine();
            if (!int.TryParse(inputNumTwo, out int numTwo))
            {
                Console.WriteLine("Incorect input!");
                return;
            }

            Console.WriteLine("Please choose an operation from those listed:");
            Console.WriteLine("For Addition press: +");
            Console.WriteLine("For Subtraction press: -");
            Console.WriteLine("For Multiplication press: *");
            Console.WriteLine("For Division press: /");

            string inputOperation = Console.ReadLine();
            switch (inputOperation)
            {
                case "+":
                    int additionResult = numOne + numTwo;
                    Console.WriteLine($"Your result is: {additionResult}.");
                    break;
                case "-":
                    int subtractionResult = numTwo - numOne;
                    Console.WriteLine($"Your result is: {subtractionResult}");
                    break;
                case "*":
                    int multiplicationResult = numOne * numTwo;
                    Console.WriteLine($"Yor result is: {multiplicationResult}");
                    break;
                case "/":
                    int divisionResult = numOne / numTwo;
                    Console.WriteLine($"Your result is: {divisionResult}");
                    break;
                default:
                    Console.WriteLine("You have chosen wrong operation!");
                    break;
            }
        }
    }
}