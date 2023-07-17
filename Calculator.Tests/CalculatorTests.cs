[TestFixture]
public class CalculatorTests
{
    private Calculator.Calculator calculator;

    [SetUp]
    public void SetUp()
    {
        calculator = new Calculator.Calculator();
    }

    [TestCaseSource(nameof(ValidTestCases))]
    public void TestCalculatorWithValidInput(string expression, double expected)
    {
        double result = calculator.Calculate(expression);
        Assert.AreEqual(expected, result, 1e-9);
    }

    [TestCaseSource(nameof(InvalidTestCases))]
    public void TestCalculatorWithInvalidInput(string expression, Type expectedErrorType)
    {
        Assert.Throws(expectedErrorType, () => calculator.Calculate(expression));
    }

    private static IEnumerable<TestCaseData> ValidTestCases()
    {
        yield return new TestCaseData("1 + 2", 3.0);
        yield return new TestCaseData("12 - 9", 3.0);
        yield return new TestCaseData("6 * 7", 42.0);
        yield return new TestCaseData("2 ** 6", 64.0);
        yield return new TestCaseData("100 / 8", 12.5);
        yield return new TestCaseData("72 // 3", 24.0);
        yield return new TestCaseData("42 % 10", 2.0);
        yield return new TestCaseData("1 + 9 * 2", 19.0);
        yield return new TestCaseData("4 ** 3 - 5", 59.0);
        yield return new TestCaseData("12345 // 10 % 100", 5.0);
        yield return new TestCaseData("12.5 - 50 / 8", 6.25);
        yield return new TestCaseData("(1 + 9) * 2", 20.0);
        yield return new TestCaseData("4 ** (3 - 5)", 0.0625);
        yield return new TestCaseData("12345 // (10 % 100)", 12345.0);
        yield return new TestCaseData("(12.5 - 50) / 8", -5.8125);
        yield return new TestCaseData("1 + 2 - 3 * 4 / 5", 0.6);
        yield return new TestCaseData("11 ** 8 // 1000 % 10", 6.0);
        yield return new TestCaseData("(1 + ((2 - 3) * 4)) / 5", -0.2);
        yield return new TestCaseData("11 ** ((1000 // 8) % 10)", 1.0);
        yield return new TestCaseData("-8 - 5", -13.0);
        yield return new TestCaseData("-20 - +23", -43.0);
        yield return new TestCaseData("(-1 + -9) * 2", -20.0);
        yield return new TestCaseData("-4 ** (+3 - -5)", -1024.0);
        yield return new TestCaseData("2 / -25", -0.08);
        yield return new TestCaseData("-1000 // +12", -83.0);
        yield return new TestCaseData("-80 % -3", -2.0);
        yield return new TestCaseData("+11 ** ((+1000 // +8) % +10)", 1.0);
        yield return new TestCaseData("1.0 + 2.0", 3.0);
        yield return new TestCaseData("(23.45 / 5.0) - 9.87", -5.602);
        yield return new TestCaseData("1.5 * (2.7 - 1.2)", 1.65);
        yield return new TestCaseData("6.25 ** 3.5", 284.9794910297);
        yield return new TestCaseData("43.2 / 1.2", 36.0);
        yield return new TestCaseData("83.4 // 24.6", 3.0);
        yield return new TestCaseData("1.234 % 1.0", 0.234);
        yield return new TestCaseData("1.5 + -2.5", -1.0);
        yield return new TestCaseData("-2.0 - +6.32", -8.32);
        yield return new TestCaseData("-23.4 * 56.7", -1322.58);
        yield return new TestCaseData("+0.064 ** -1.333", 10.7969192694);
        yield return new TestCaseData("-1.23 / 4.56", -0.2697368421);
        yield return new TestCaseData("12.5 // +2.5", 5.0);
        yield return new TestCaseData("-123.45 % -3.5", -0.95);
        yield return new TestCaseData("-1.4 * (+2.6 ** 7)", -2805.4841664);
        yield return new TestCaseData("1 + 2", 3.0);
        yield return new TestCaseData("12 - 9", 3.0);
        yield return new TestCaseData("6 * 7", 42.0);
        yield return new TestCaseData("2 ** 6", 64.0);
        yield return new TestCaseData("100 / 8", 12.5);
        yield return new TestCaseData("72 // 3", 24.0);
        yield return new TestCaseData("42 % 10", 2.0);
        yield return new TestCaseData("1 + 9 * 2", 19.0);
        yield return new TestCaseData("4 ** 3 - 5", 59.0);
        yield return new TestCaseData("12345 // 10 % 100", 5.0);
        yield return new TestCaseData("12.5 - 50 / 8", 6.25);
        yield return new TestCaseData("(1 + 9) * 2", 20.0);
        yield return new TestCaseData("4 ** (3 - 5)", 0.0625);
        yield return new TestCaseData("12345 // (10 % 100)", 12345.0);
        yield return new TestCaseData("(12.5 - 50) / 8", -5.8125);
        yield return new TestCaseData("1 + 2 - 3 * 4 / 5", 0.6);
        yield return new TestCaseData("11 ** 8 // 1000 % 10", 6.0);
        yield return new TestCaseData("(1 + ((2 - 3) * 4)) / 5", -0.2);
        yield return new TestCaseData("11 ** ((1000 // 8) % 10)", 1.0);
        yield return new TestCaseData("-8 - 5", -13.0);
        yield return new TestCaseData("-20 - +23", -43.0);
        yield return new TestCaseData("(-1 + -9) * 2", -20.0);
        yield return new TestCaseData("-4 ** (+3 - -5)", -1024.0);
        yield return new TestCaseData("2 / -25", -0.08);
        yield return new TestCaseData("-1000 // +12", -83.0);
        yield return new TestCaseData("-80 % -3", -2.0);
        yield return new TestCaseData("+11 ** ((+1000 // +8) % +10)", 1.0);
        yield return new TestCaseData("1.0 + 2.0", 3.0);
        yield return new TestCaseData("(23.45 / 5.0) - 9.87", -5.602);
        yield return new TestCaseData("1.5 * (2.7 - 1.2)", 1.65);
        yield return new TestCaseData("6.25 ** 3.5", 284.9794910297);
        yield return new TestCaseData("43.2 / 1.2", 36.0);
        yield return new TestCaseData("83.4 // 24.6", 3.0);
        yield return new TestCaseData("1.234 % 1.0", 0.234);
        yield return new TestCaseData("1.5 + -2.5", -1.0);
        yield return new TestCaseData("-2.0 - +6.32", -8.32);
        yield return new TestCaseData("-23.4 * 56.7", -1322.58);
        yield return new TestCaseData("+0.064 ** -1.333", 10.7969192694);
        yield return new TestCaseData("-1.23 / 4.56", -0.2697368421);
        yield return new TestCaseData("12.5 // +2.5", 5.0);
        yield return new TestCaseData("-123.45 % -3.5", -0.95);
        yield return new TestCaseData("-1.4 * (+2.6 ** 7)", -2805.4841664);
    }

    private static IEnumerable<TestCaseData> InvalidTestCases()
    {
        yield return new TestCaseData("5 / 0", typeof(DivideByZeroException));
        yield return new TestCaseData("6 // 0", typeof(DivideByZeroException));
        yield return new TestCaseData("7 % 0", typeof(DivideByZeroException));
        yield return new TestCaseData("0 ** -1", typeof(DivideByZeroException));
        yield return new TestCaseData("1234.0 ** 5678", typeof(OverflowException));
        yield return new TestCaseData("4 +", typeof(FormatException));
        yield return new TestCaseData("// 10", typeof(FormatException));
        yield return new TestCaseData("1 + 9 2", typeof(FormatException));
        yield return new TestCaseData("4 ** // 5", typeof(FormatException));
        yield return new TestCaseData("12. 5 - 50 / 8", typeof(FormatException));
        yield return new TestCaseData("1 + 9) * 2", typeof(FormatException));
        yield return new TestCaseData("4 ** (3 - 5", typeof(FormatException));
        yield return new TestCaseData("(12345 // (10 % 100)", typeof(FormatException));
        yield return new TestCaseData("((12.5 - 50) / 8", typeof(FormatException));
        yield return new TestCaseData("(1 + (2 - 3) * 4)) / 5", typeof(FormatException));
        yield return new TestCaseData("11 ** ((1000 // 8 % 10)))", typeof(FormatException));
    }
}
