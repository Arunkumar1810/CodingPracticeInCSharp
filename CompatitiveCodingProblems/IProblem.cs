using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitiveCodingProblems
{
    interface IProblem
    {
        public void GetInputs();
        public void Solve();
        public void PrintOutput();
    }
}
