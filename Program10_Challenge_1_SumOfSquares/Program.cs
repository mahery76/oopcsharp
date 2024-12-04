class SumOfSquares
{
    public double SquaresSum(double num1, double num2, double num3)
    {
        double sum = 0;
        sum = num1*num1 + num2*num2 + num3*num3;
        return sum;
    }
}
class Program
{
    public static void Main(string[] args)
    {
        var item = new SumOfSquares();
        Console.WriteLine(item.SquaresSum(4, 5, 7));
    }
}