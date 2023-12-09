using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LockSolver.ConsoleApp
{

    public class TwoRightDigitWrongPlaceHint : IHint
    {
        private readonly string hint;

        public TwoRightDigitWrongPlaceHint(string hint)
        {
            this.hint = hint;
        }

        public bool IsMatch(string candidate)
        {
            int matchConut = 0;
            for (int i = 0; i < candidate.Length; i++)
            {
                if (candidate.Contains(hint[i]) && candidate[i] != hint[i] )
                {
                    matchConut++;
                }
            }
            return matchConut == 2;
            return candidate.Zip(hint,(c,h) => c != h && hint.Contains(c) ? 1 : 0).Sum() == 2;
        }
    }
}
