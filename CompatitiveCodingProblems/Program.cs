namespace CompetitiveCodingProblems
{
    public class Program
    {
        public static void Main(string[] args)
        {

            do
            {
                Console.WriteLine("Enter the option :");

                Console.WriteLine("9. Palindrome Number");

                Console.WriteLine("0. Quit");

                if (!int.TryParse(Console.ReadLine(), out var option))
                {
                    Console.WriteLine("Provide a number that matches ");
                }

                IProblem? problem = null;

                switch (option)
                {
                    case 9:
                        problem = new PalindromeNumber();
                        break;

                    case 0: return;

                    default:
                        Console.WriteLine("Number doesn't match with any problem.");
                        break;
                }

                if (problem == null) continue;
                problem.GetInputs();
                problem.Solve();
                problem.PrintOutput();
            } while (true);
        }
    }
}