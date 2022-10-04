namespace CompetitiveCodingProblems
{
    internal class PalindromeNumber : IProblem
    {
        private int _number = 0;
        private string _keyWord = "";

        public void GetInputs()
        {
            Console.WriteLine("Enter the number to check if that is palindrome number :");
            if (!int.TryParse(Console.ReadLine(), out _number))
            {
                Console.WriteLine("The given input is not right.");
            }
        }

        public void Solve()
        {
            if (!IsPalindrome())
            {
                _keyWord = "not ";
            }
        }

        public void PrintOutput()
        {
            Console.WriteLine($"{_number} is {_keyWord}a palindrome.");
        }

        public bool IsPalindrome()
        {
            int reverseNumber = 0, x = _number;
            while (x>0)
            {
                reverseNumber = reverseNumber * 10 + x % 10;
                x /= 10;
            }

            return reverseNumber == _number;
        }
    }
}
