using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LockSolver.ConsoleApp
{
    public interface IHint
    {
        public bool IsMatch(string candidate);
    }
}
