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
    //getter forname
    public string GetName()
    {
        return this._name;
    }
    //public method to print details
    public void PrintDetails()
    {
        Console.WriteLine("Name: " + this._name);
        Console.WriteLine("price: " + this._price);
        Console.WriteLine("expiryDate: " + this._expiryDate);
    }
}
// derived class beverage
class Beverage : Product
{
    // Private fields : Fields specific to the derived class
    private double _litres;
    private string _flavor;

    // Parameterized constructor
    public Beverage(string name, double price, string expiryDate, double litres, string flavor)
         : base(name, price, expiryDate) 
    {
        this._litres = litres;
        this._flavor = flavor;
    }

    public void BeverageDetails()
    {
        PrintDetails();
        Console.WriteLine("Litres: {0}ml", this._litres);
        Console.WriteLine("Flavor: {0} \n", this._flavor);
    }
}

class Chocolate : Product
{
    // specification of a chocolate
    private bool _isMilky;
    private double _grams;

    // Constructor
    public Chocolate(string name, double price, string expiryDate, double grams, bool isMilky)
        : base(name, price, expiryDate)
    {
        this._grams = grams;
        this._isMilky = isMilky;
    }
    public void ChocolateDetails()
    {
        PrintDetails();
        Console.WriteLine("is the {0} milky? {1}", GetName(), this._isMilky);
        Console.WriteLine("The {0} bar wieghs: {1}g", GetName(), this._grams);
    }
}

class Demo
{
    public static void Main(string[] args)
    {
        var cola = new Beverage("RC Cola", 0.9, "12/12/2019", 350, "Cola");
        cola.BeverageDetails();

        var crunch = new Chocolate("Crunch", 2.3, "3/9/2019", 43, true);
        crunch.ChocolateDetails();
    }
}