using System;

namespace MathOperations
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Input a number.");
            var operand1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Input another number.");
            var operand2 = double.Parse(Console.ReadLine());

            var sum = operand1 + operand2;
            var difference = operand1 - operand2;
            var division = operand1 / operand2;
            var multiplication = operand1 * operand2;
            var remainder = operand1 % operand2;

            ShowResults(sum, difference, multiplication, division, remainder);

        }
        public static void ShowResults(double sum, double difference, double multiplication, double division, double remainder)
        {
            Console.WriteLine($"The sum is {sum}.");
            Console.WriteLine($"The difference is {difference}.");
            Console.WriteLine($"The quotient is {division}.");
            Console.WriteLine($"The product is {multiplication}.");
            Console.WriteLine($"The remainder is {remainder}.");
        }
    }
}
