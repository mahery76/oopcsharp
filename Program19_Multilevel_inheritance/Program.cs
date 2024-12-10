class Product
{
    private string _name;
    private double _price;
    private string _expiryDate;

    // Parameterized Constructor
    public Product(string name, double price, string expiryDate)
    {
        this._name = name;
        this._price = price;
        this._expiryDate = expiryDate;
    }

    // getter for name
    public string GetName()
    {
        return this._name;
    }

    // public method to print details
    public void PrintDetails()
    {
        Console.WriteLine("Name: " + this._name);
        Console.WriteLine("Price: " + this._price);
        Console.WriteLine("Expiry Date: " + this._expiryDate);
    }

}
class Beverage : Product
{
    // Private fields : Fields specific to the derived class
    private double _litres;
    private string _flavor;

    // Parameterized Coonstructor
    public Beverage(string name, double price, string expiryDate, double litres, string flavor)
    : base(name, price, expiryDate) 
    {
        this._litres = litres;
        this._flavor = flavor;
    }
    public void BeverageDetails()
    {
        PrintDetails();
        Console.WriteLine("Litres: " + this._litres);
        Console.WriteLine("Flavor: " + this._flavor);
    }
}

class Soda : Beverage
{// Inheriting beverage
    // Specifications of a soda
    private bool _isCaffeinated;
    private bool _isDiet;

    // Constructor
    public Soda(string name, double price, string expiryDate, double litres, string flavor, bool isCaffeinated, bool isDiet)
    :base (name, price, expiryDate, litres, flavor)
    {
        this._isCaffeinated = isCaffeinated;
        this._isDiet = isDiet;
    }
    public void SodaDetails()
    {
        BeverageDetails();
        Console.WriteLine("Is the {0} caffeinated? {1}", GetName(), this._isCaffeinated);
        Console.WriteLine("Is the {0} diet? {1}", GetName(), this._isDiet);
    }
}

class Demo
{
    public static void Main(string[] args)
    {
        var cola = new Soda("CocaCola", 0.9, "12/12/2011", 0.35, "lemon", false, true);
        cola.SodaDetails();
    }
}
