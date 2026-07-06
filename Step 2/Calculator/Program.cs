using System;

namespace Calculator;

public class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            int? a = Input("Enter the first operand or type 'exit' to close the program: ");
            if (a == null) break;
            int? b = Input("Enter the second operand or type 'exit' to close the program: ");
            if (b == null) break;

            Console.Write("Specify the operation like +, -, 'Add', 'Multiplication' etc. or type 'exit' to close the program: ");
            string operation = Console.ReadLine()?.Trim().ToLower() ?? string.Empty;

            if (operation == "exit") break;

            try
            {
                int result = Executor(operation, a.Value, b.Value);
                Console.WriteLine($"The result of {a.Value} {operation} {b.Value} = {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[ERROR] {ex.Message}");
            }
        }
    }

    static int Executor(string operation, int a, int b)
    {
        return operation switch
        {
            "+" or "add" or "addition" => Calculator.Add(a, b),
            "-" or "subtract" or "subtraction" => Calculator.Subtract(a, b),
            "*" or "multiply" or "multiplication" => Calculator.Multiply(a, b),
            "/" or "divide" or "division" => Calculator.Divide(a, b),
            _ => throw new ArgumentException("Invalid operation"),
        };
    }

    static int? Input(string prompt)
    {
        Console.Write(prompt);
        while (true)
        {
            var line = Console.ReadLine()?.Trim().ToLower();
            if (line == "exit") return null;

            if (int.TryParse(line, out var value)) return value;

            Console.WriteLine("Invalid input, please try again.");
        }
    }
}

public static class Calculator
{
    public static int Add(int a, int b) => a + b;
    public static int Subtract(int a, int b) => a - b;
    public static int Multiply(int a, int b) => a * b;
    public static int Divide(int a, int b)
    {
        if (b == 0)
            throw new ArgumentException("Cannot divide by zero!");
        return a / b;
    }
}