namespace Calculator;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the first operand: ");
        int a = int.TryParse(Console.ReadLine());
        
        Console.Write("Enter the second operand: ");
        int b = int.TryParse(Console.ReadLine());
        
        Console.Write("Enter the operation name ['Addition', 'Subtraction', 'Multiplication', 'Division']");
        string operation = Console.ReadLine();

        switch(operation)
        {
            case "Addition":
                Console.WriteLine(Calculator.Add(a, b));
                break;
            case "Subtraction":
                Console.WriteLine(Calculator.Subtract(a, b));
                break;
            case "Multiplication":
                Console.WriteLine(Calculator.Multiply(a, b));
                break;
            case "Division":
                Console.WriteLine(Calculator.Divide(a, b));
                break;
            default:
                Console.WriteLine("NoThInG!");
                break;
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