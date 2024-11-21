namespace Week_3_Challenge_Lab_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string containing single digits:");
            string input = Console.ReadLine();

            int sum = SumOfDigits(input);

            Console.WriteLine($"The sum of all digits in the string is: {sum}");
        }

        static int SumOfDigits(string str)
        {
            int sum = 0;

            foreach (char c in str)
            {
                // Check if the character is a digit
                if (char.IsDigit(c))
                {
                    // Convert the digit character to its integer value and add to sum
                    sum += c - '0';
                }
            }

            return sum;
        }
    }
}
