using MyCalculator = Calculator.Calculator;

[TestFixture]
public class CalculatorTests
{
    [TestCaseSource(nameof(ValidTestCases))]
    public void TestCalculatorWithValidInput(string expression, double expected)
    {
        double result = MyCalculator.Calculate(expression);
        Assert.AreEqual(expected, result, 1e-9);
    }

    [TestCaseSource(nameof(InvalidTestCases))]
    public void TestCalculatorWithInvalidInput(string expression, Type expectedErrorType)
    {
        Assert.Throws(expectedErrorType, () => MyCalculator.Calculate(expression));
    }

    private static IEnumerable<TestCaseData> ValidTestCases()
    {
        yield return new TestCaseData("1 + 2", 1 + 2);
        yield return new TestCaseData("12 - 9", 12 - 9);
        yield return new TestCaseData("6 * 7", 6 * 7);
        yield return new TestCaseData("2 * 6", 2 * 6);
        yield return new TestCaseData("100 / 8", 100 / 8);
        yield return new TestCaseData("72 / 3", 72 / 3);
        yield return new TestCaseData("42 % 10", 42 % 10);
        yield return new TestCaseData("1 + 9 * 2", 1 + 9 * 2);
        yield return new TestCaseData("4 * 3 - 5", 4 * 3 - 5);
        yield return new TestCaseData("12345 / 10 % 100", 12345 / 10 % 100);
        yield return new TestCaseData("12.5 - 50 / 8", 12.5 - 50 / 8);
        yield return new TestCaseData("(1 + 9) * 2", (1 + 9) * 2);
        yield return new TestCaseData("4 * (3 - 5)", 4 * (3 - 5));
        yield return new TestCaseData("12345 / (10 % 100)", 12345 / (10 % 100));
        yield return new TestCaseData("(12.5 - 50) / 8", (12.5 - 50) / 8);
        yield return new TestCaseData("1 + 2 - 3 * 4 / 5", 1 + 2 - 3 * 4 / 5);
        yield return new TestCaseData("11 * 8 / 1000 % 10", 11 * 8 / 1000 % 10);
        yield return new TestCaseData("(1 + ((2 - 3) * 4)) / 5", (1 + ((2 - 3) * 4)) / 5);
        yield return new TestCaseData("11 * ((1000 / 8) % 10)", 11 * ((1000 / 8) % 10));
        yield return new TestCaseData("-8 - 5", -8 - 5);
        yield return new TestCaseData("-20 - +23", -20 - +23);
        yield return new TestCaseData("(-1 + -9) * 2", (-1 + -9) * 2);
        yield return new TestCaseData("-4 * (+3 - -5)", -4 * (+3 - -5));
        yield return new TestCaseData("2 / -25", 2 / -25);
        yield return new TestCaseData("-1000 / +12", -1000 / +12);
        yield return new TestCaseData("-80 % -3", -80 % -3);
        yield return new TestCaseData("+11 * ((+1000 / +8) % +10)", +11 * ((+1000 / +8) % +10));
        yield return new TestCaseData("1.0 + 2.0", 1.0 + 2.0);
        yield return new TestCaseData("(23.45 / 5.0) - 9.87", (23.45 / 5.0) - 9.87);
        yield return new TestCaseData("1.5 * (2.7 - 1.2)", 1.5 * (2.7 - 1.2));
        yield return new TestCaseData("6.25 * 3.5", 6.25 * 3.5);
        yield return new TestCaseData("43.2 / 1.2", 43.2 / 1.2);
        yield return new TestCaseData("83.4 / 24.6", 83.4 / 24.6);
        yield return new TestCaseData("1.234 % 1.0", 1.234 % 1.0);
        yield return new TestCaseData("1.5 + -2.5", 1.5 + -2.5);
        yield return new TestCaseData("-2.0 - +6.32", -2.0 - +6.32);
        yield return new TestCaseData("-23.4 * 56.7", -23.4 * 56.7);
        yield return new TestCaseData("+0.064 * -1.333", +0.064 * -1.333);
        yield return new TestCaseData("-1.23 / 4.56", -1.23 / 4.56);
        yield return new TestCaseData("12.5 / +2.5", 12.5 / +2.5);
        yield return new TestCaseData("-123.45 % -3.5", -123.45 % -3.5);
        yield return new TestCaseData("-1.4 * (+2.6 * 7)", -1.4 * (+2.6 * 7));
        yield return new TestCaseData(" 1 + 2", 1 + 2);
        yield return new TestCaseData("12  - 9", 12 - 9);
        yield return new TestCaseData("6 *  7", 6 * 7);
        yield return new TestCaseData("2 * 6 ", 2 * 6);
        yield return new TestCaseData(" 100  / 8", 100 / 8);
        yield return new TestCaseData(" 72 /  3", 72 / 3);
        yield return new TestCaseData(" 42 % 10 ", 42 % 10);
        yield return new TestCaseData("1  +  9 * 2", 1 + 9 * 2);
        yield return new TestCaseData("4  * 3  - 5", 4 * 3 - 5);
        yield return new TestCaseData("12345  / 10 %  100", 12345 / 10 % 100);
        yield return new TestCaseData("12.5  - 50 / 8 ", 12.5 - 50 / 8);
        yield return new TestCaseData("(1 + 9 ) * 2", (1 + 9) * 2);
        yield return new TestCaseData("4 * ( 3 - 5)", 4 * (3 - 5));
        yield return new TestCaseData("12345 / (10  %  100)", 12345 / (10 % 100));
        yield return new TestCaseData("(12.5 - 50)  / 8 ", (12.5 - 50) / 8);
        yield return new TestCaseData("1 + 2 - 3 * 4 /  5 ", 1 + 2 - 3 * 4 / 5);
        yield return new TestCaseData("  11   * 8 / 1000 % 10", 11 * 8 / 1000 % 10);
        yield return new TestCaseData(" ( 1 + ( (2  - 3) * 4)) / 5", (1 + ((2 - 3) * 4)) / 5);
        yield return new TestCaseData("11   * ((1000 /  8 ) % 10)", 11 * ((1000 / 8) % 10));
        yield return new TestCaseData(" -8  - 5 ", -8 - 5);
        yield return new TestCaseData(" -20  -  +23", -20 - +23);
        yield return new TestCaseData("(-1  +  -9) *  2", (-1 + -9) * 2);
        yield return new TestCaseData("-4  *  (+3  -   -5)", -4 * (+3 - -5));
        yield return new TestCaseData("2  /  -25", 2 / -25);
        yield return new TestCaseData("-1000  / +12  ", -1000 / +12);
        yield return new TestCaseData(" -80  % -3", -80 % -3);
        yield return new TestCaseData(" +11  * ( ( +1000 / +8 )  % +10 )", +11 * ((+1000 / +8) % +10));
        yield return new TestCaseData(" 1.0 + 2.0", 1.0 + 2.0);
        yield return new TestCaseData("(23.45  / 5.0) - 9.87", (23.45 / 5.0) - 9.87);
        yield return new TestCaseData("1.5 * (2.7  - 1.2)", 1.5 * (2.7 - 1.2));
        yield return new TestCaseData("6.25 * 3.5 ", 6.25 * 3.5);
        yield return new TestCaseData("  43.2 / 1.2", 43.2 / 1.2);
        yield return new TestCaseData("83.4   / 24.6", 83.4 / 24.6);
        yield return new TestCaseData("1.234 %   1.0", 1.234 % 1.0);
        yield return new TestCaseData("1.5 + -2.5  ", 1.5 + -2.5);
        yield return new TestCaseData(" -2.0  - +6.32 ", -2.0 - +6.32);
        yield return new TestCaseData(" -23.4 * 56.7  ", -23.4 * 56.7);
        yield return new TestCaseData("+0.064 *   -1.333", +0.064 * -1.333);
        yield return new TestCaseData("-1.23   / 4.56", -1.23 / 4.56);
        yield return new TestCaseData(" 12.5 /    +2.5", 12.5 / +2.5);
        yield return new TestCaseData("-123.45    % -3.5 ", -123.45 % -3.5);
        yield return new TestCaseData("-1.4  *  (+2.6  *  7)", -1.4 * (+2.6 * 7));
    }

    private static IEnumerable<TestCaseData> InvalidTestCases()
    {
        yield return new TestCaseData("5 / 0", typeof(DivideByZeroException));
        yield return new TestCaseData("6 / 0", typeof(DivideByZeroException));
        yield return new TestCaseData("7 % 0", typeof(DivideByZeroException));
        yield return new TestCaseData("4 +", typeof(FormatException));
        yield return new TestCaseData("/ 10", typeof(FormatException));
        yield return new TestCaseData("1 + 9 2", typeof(FormatException));
        yield return new TestCaseData("4 * / 5", typeof(FormatException));
        yield return new TestCaseData("12. 5 - 50 / 8", typeof(FormatException));
        yield return new TestCaseData("12 .5 - 50 / 8", typeof(FormatException));
        yield return new TestCaseData("12 . 5 - 50 / 8", typeof(FormatException));
        yield return new TestCaseData("1 + 9) * 2", typeof(FormatException));
        yield return new TestCaseData("4 * (3 - 5", typeof(FormatException));
        yield return new TestCaseData("(12345 / (10 % 100)", typeof(FormatException));
        yield return new TestCaseData("((12.5 - 50) / 8", typeof(FormatException));
        yield return new TestCaseData("(1 + (2 - 3) * 4)) / 5", typeof(FormatException));
        yield return new TestCaseData("11 * ((1000 / 8 % 10)))", typeof(FormatException));
    }
}
