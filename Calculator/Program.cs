var calculator = new Calculator.Calculator();

Console.WriteLine($"1 + 2 = {calculator.Calculate("1 + 2")} (should be {1 + 2})");
Console.WriteLine($"12 - 9 = {calculator.Calculate("12 - 9")} (should be {12 - 9})");
Console.WriteLine($"6 * 7 = {calculator.Calculate("6 * 7")} (should be {6 * 7})");
Console.WriteLine($"100 / 8 = {calculator.Calculate("100 / 8")} (should be {100 / 8})");
Console.WriteLine($"42 % 10 = {calculator.Calculate("42 % 10")} (should be {42 % 10})");
Console.WriteLine($"2 * (1 + 3) = {calculator.Calculate("2 * (1 + 3)")} (should be {2 * (1 + 3)})");
