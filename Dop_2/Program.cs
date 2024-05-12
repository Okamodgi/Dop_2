using System;

class Program
{
    static void Main(string[] args)
    {
        ComplexNumber num1 = new ComplexNumber(3, 4);
        ComplexNumber num2 = new ComplexNumber(1, -2);

        Console.WriteLine($"число 1 = {num1}");
        Console.WriteLine($"число 2 = {num2}");

        ComplexNumber sum = num1.Add(num2.Real, num2.Imaginary);
        Console.WriteLine($"Сумма: {sum}");

        ComplexNumber difference = num1.Subtract(num2.Real, num2.Imaginary);
        Console.WriteLine($"Разность: {difference}");

        ComplexNumber product = num1.Multiply(num2.Real, num2.Imaginary);
        Console.WriteLine($"Произведение: {product}");

        ComplexNumber quotient = num1.Divide(num2.Real, num2.Imaginary);
        Console.WriteLine($"Частное: {quotient}");
    }
}
