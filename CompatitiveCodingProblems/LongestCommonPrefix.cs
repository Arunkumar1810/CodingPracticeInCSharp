namespace CompetitiveCodingProblems
{
    class LongestCommonPrefix : IProblem
    {
        private string[]? _inputStrings;
        private string? _longestCommonPrefix;
        private string? _input;
        public void GetInputs()
        {
            Console.WriteLine("Enter the strings separated by comma to find the longest common prefix");
            _input = Console.ReadLine();
            if (_input != null)
            {
                _inputStrings = _input.Split(",");
                for (int index = 0; index < _inputStrings.Length; index++)
                {
                    _inputStrings[index] = _inputStrings[index].Trim();
                    if (_inputStrings[index].StartsWith('"'))
                    {
                        _inputStrings[index] = _inputStrings[index].Remove(0, 1);
                    }

                    if (_inputStrings[index].EndsWith('"'))
                    {
                        _inputStrings[index] = _inputStrings[index].Remove(_inputStrings[index].Length - 1, 1);
                    }
                }
            }
            else Console.WriteLine("Provide a proper _input");
        }

        public void Solve()
        {
            if (_inputStrings != null) _longestCommonPrefix = FindLongestCommonPrefix(_inputStrings);
        }

        public void PrintOutput()
        {
            if(_longestCommonPrefix != null) Console.WriteLine($"The longest common prefix for the _input strings {_input} is {_longestCommonPrefix}");
        }
        public string FindLongestCommonPrefix(string[] strs)
        {
            string commonPrefix = strs[0];
            int commonCount = commonPrefix.Length;

            foreach (var str in strs.Skip(1))
            {
                if (str.Length < commonCount)
                {
                    commonPrefix = str;
                    commonCount = str.Length;
                }
            }

            foreach (var str in strs)
            {
                int newCommonCount = 0;
                for (int i = 0; i < commonCount && i<str.Length; i++)
                {
                    if (commonPrefix[i] == str[i])
                    {
                        newCommonCount++;
                    }
                    else
                    {
                        break;
                    }
                }
                commonCount = newCommonCount;
                if (commonCount == 0)
                {
                    break;
                }
            }

            commonPrefix = commonPrefix.Remove(commonCount);
            return commonPrefix;
        }
    }
}
