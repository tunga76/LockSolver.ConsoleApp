using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LockSolver.ConsoleApp
{
    public class ExactMatchHint : IHint
    {
        private readonly string hint;

        public ExactMatchHint(string hint)
        {
            this.hint = hint;
        }
        public bool IsMatch(string candidate)
        {
            for (int i = 0; i < candidate.Length; i++)
                if (candidate[i] == hint[i])
                    return true;
            return false;
            return candidate.Zip(hint, (c, h) => c == h ? 1 : 0).Sum() == 1;
        }
    }
}
