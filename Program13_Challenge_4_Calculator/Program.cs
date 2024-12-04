class Calculator {
    private double _num1;
    private double _num2;

    public Calculator(double num1, double num2){
        this._num1 = num1;
        this._num2 = num2;
    }
    public double Add(){
        return this._num1 + this._num2;
    }

    public double Subtract(){
        return this._num1 - this._num2;
    }
    public double multiply(){
        return this._num1 * this._num2;
    }
    public double divide(){
        return this._num1/this._num2;
    }
}
class Program{
    public static void Main(string[] args){
        Calculator calculator = new Calculator(10, 46);
        Console.WriteLine("addition: " + calculator.Add());
    }
}