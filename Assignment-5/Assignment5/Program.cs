using Assignment5;

public class Program
{
    public static void Main(String[] args)
    {
        Calculator calc = new Calculator();
        Console.WriteLine("Add two numbers");

        Console.WriteLine("Result: " + calc.Add(12, 12));

        Console.WriteLine("Subtract two numbers");

        Console.WriteLine("Result: " + calc.Sub(12, 12));

    
        Console.WriteLine("Multiply two numbers");

        Console.WriteLine("Result: " + calc.Mul(12, 12));

        Console.WriteLine("Divide two numbers");

        Console.WriteLine("Result: " + calc.Div(12, 12));
    }
}