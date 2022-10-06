using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitiveCodingProblems
{
    public class RomanToInteger : IProblem
    {
        private string? _romanNumber = "";
        private int _number = 0;

        public void GetInputs()
        {
            Console.WriteLine("Enter the roman number :");
            _romanNumber = Console.ReadLine();
        }

        public void Solve()
        {
            _number = RomanToInt(_romanNumber);
        }

        public void PrintOutput()
        {
            Console.WriteLine($"Decimal value of roman number {_romanNumber} is {_number}");
        }

        public int RomanToInt(string romanNumber)
        {
            int result = 0, prevValue = 0;
            foreach(var character in romanNumber.ToCharArray())
            {
                var value = getIntegerValueOfRomanCharacter(character);
                if (value < prevValue)
                {
                    result += value;
                }
                else
                {
                    result = (result - prevValue) + (value - prevValue);
                }
                prevValue = value;
            }

            return result;
        }

        public int getIntegerValueOfRomanCharacter(char romanCharacter)
        {
            return romanCharacter switch
            {
                'I' => 1,
                'V' => 5,
                'X' => 10,
                'L' => 50,
                'C' => 100,
                'D' => 500,
                'M' => 1000,
                _ => 0
            };
        }
    }
}
