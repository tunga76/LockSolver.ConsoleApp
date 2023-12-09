using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LockSolver.ConsoleApp
{
    public class NoMatchHint : IHint
    {
        private readonly string hint;

        public NoMatchHint(string hint)
        {
            this.hint = hint;
        }
        public bool IsMatch(string candidate)
        {
            for (int i = 0; i < candidate.Length; i++)
            {
                if (candidate.Contains(hint[i]))
                    return false;
            }
            return true;

            return !candidate.Any(c=> hint.Contains(c));
        }
    }
}
