interface IAddition{
    int AddTwo(int num1, int num2);
}

// calculator class implementing the addition interface
class Calculator : IAddition{
    public int AddTwo(int num1, int num2)
    {
        return num1 + num2;
    }
}
class Demo {
    public static void Main(string[] args)
    {
        Calculator cal = new Calculator();
        Console.WriteLine(cal.AddTwo(10, 20));
    }
}
