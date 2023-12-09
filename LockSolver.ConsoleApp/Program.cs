namespace LockSolver.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LockSolver lockSolver = new(GetHints(),3);

            var key = lockSolver.Solve();

            Console.WriteLine("Key : {0}", key);
        }


        static List<IHint> GetHints()
        {
            return new List<IHint>()
            {
                new ExactMatchHint("682"),
                new RightDigitWrongPlaceHint("614"),
                new TwoRightDigitWrongPlaceHint("206"),
                new NoMatchHint("738"),
                new RightDigitWrongPlaceHint("780")
            };
        }
    }
}