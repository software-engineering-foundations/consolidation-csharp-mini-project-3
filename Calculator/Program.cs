using MyCalculator = Calculator.Calculator;

Console.WriteLine($"1 + 2 = {MyCalculator.Calculate("1 + 2")} (should be {1 + 2})");
Console.WriteLine($"12 - 9 = {MyCalculator.Calculate("12 - 9")} (should be {12 - 9})");
Console.WriteLine($"6 * 7 = {MyCalculator.Calculate("6 * 7")} (should be {6 * 7})");
Console.WriteLine($"100 / 8 = {MyCalculator.Calculate("100 / 8")} (should be {100 / 8})");
Console.WriteLine($"42 % 10 = {MyCalculator.Calculate("42 % 10")} (should be {42 % 10})");
Console.WriteLine($"2 * (1 + 3) = {MyCalculator.Calculate("2 * (1 + 3)")} (should be {2 * (1 + 3)})");
