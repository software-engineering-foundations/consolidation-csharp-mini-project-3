namespace Calculator
{
    public class Calculator
    {
        private Dictionary<string, Func<double, double, double>> operators;

        public Calculator()
        {
            operators = new Dictionary<string, Func<double, double, double>>
            {
                { "+", (a, b) => a + b },
                { "-", (a, b) => a - b },
                { "*", (a, b) => a * b },
                { "**", Math.Pow },
                { "/", (a, b) => a / b },
                { "//", (a, b) => Math.Floor(a / b) },
                { "%", (a, b) => a % b }
            };
        }

        public double Calculate(string expression)
        {
            return 0;
        }
    }
}