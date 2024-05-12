public class ComplexNumber
{
    public double Real { get; set; }
    public double Imaginary { get; set; }

    public ComplexNumber(double real, double imaginary)
    {
        Real = real;
        Imaginary = imaginary;
    }

    public ComplexNumber Add(double real, double imaginary)
    {
        return new ComplexNumber(Real + real, Imaginary + imaginary);
    }

    public ComplexNumber Subtract(double real, double imaginary)
    {
        return new ComplexNumber(Real - real, Imaginary - imaginary);
    }

    public ComplexNumber Multiply(double real, double imaginary)
    {
        double newReal = Real * real - Imaginary * imaginary;
        double newImaginary = Real * imaginary + Imaginary * real;
        return new ComplexNumber(newReal, newImaginary);
    }

    public ComplexNumber Divide(double real, double imaginary)
    {
        double divisor = real * real + imaginary * imaginary;
        double newReal = (Real * real + Imaginary * imaginary) / divisor;
        double newImaginary = (Imaginary * real - Real * imaginary) / divisor;
        return new ComplexNumber(newReal, newImaginary);
    }

    public override string ToString()
    {
        if (Imaginary >= 0)
            return $"{Real} + {Imaginary}i";
        else
            return $"{Real} - {-Imaginary}i";
    }
}
