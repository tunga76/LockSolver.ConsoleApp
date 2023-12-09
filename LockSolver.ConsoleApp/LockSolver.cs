using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LockSolver.ConsoleApp
{
    public class LockSolver
    {
        private readonly List<IHint> hints;
        private readonly int digitLength;

        public LockSolver(List<IHint> hints, int digitLength)
        {
            this.hints = hints;
            this.digitLength = digitLength;
        }

        public string Solve()
        {
            for (int i = 0; i < Math.Pow(10, digitLength) -1; i++)
            {
                string candidate = i.ToString("D" + digitLength);
                if (hints.All(h=> h.IsMatch(candidate)))
                {
                    return candidate;
                }
            }
            return "No Key found";
        }
    }
}
