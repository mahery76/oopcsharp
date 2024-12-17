abstract class Beverage // base abstract class Beverage
{
    private string _name;
    private int _price;
    public Beverage(string name, int price)
    {
        this._name = name;
        this._price = price;
    }
    public int Price{
        get{
            return this._price;
        }
    }
    public string Name {
        get{
            return this._name;
        }
    }
}

interface IEnergyDrink // Interface which imposes the tax method
{
    int CalculatePrice(int price);
}

class RedBull : Beverage, IEnergyDrink // Redbull class inheriting from both
{
    public RedBull(int price)
    : base("RedBull", price){}

    // any energy drink which implements IEnergyDrink will have to implement
    public int CalculatePrice(int price)
    {
        return (base.Price + 1);
    }

    public void PrintDetails()
    {
        Console.WriteLine("The name of the drink is: "+ base.Name);
        Console.WriteLine("The price of the drink is: "+(CalculatePrice(base.Price)));
    }
}

class Program 
{
    static void Main(string[] args)
    {
        RedBull redBull = new RedBull(5);
        redBull.PrintDetails();
    }
}