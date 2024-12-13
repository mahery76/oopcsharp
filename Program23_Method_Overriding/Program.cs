class Product
{
    private string _name;
    private double _purchasePrice;

    //Parameterized Constructor
    public Product(string name, double purchasePrice)
    {
        this._name = name;
        this._purchasePrice = purchasePrice;
    }

    // getters
    public string GetName()
    {
        return this._name;
    }

    public double GetPurchasePrice()
    {
        return this._purchasePrice;
    }

    // Method to calculate selling price
    public virtual  double GetPrice()
    {
        return 0;
    }

    // Method to print details
    public virtual void PrintDetails()
    {
        Console.WriteLine("Selected Product's name:" + this.GetName());
    }
}
class Beverage : Product
{
    private double _refCost;
    private double _profit;
    // Parameterized constructor
    public Beverage(string name, double price)
    : base(name, price)
    {
        this._refCost = GetPurchasePrice() * 0.10;
        this._profit = GetPurchasePrice() * 0.15;
    }
    // public method to get selling price
    public override double GetPrice()
    {
        return (GetPurchasePrice() + (int)Math.Round(this._refCost) + (int)Math.Round(this._profit));
    }
    public override void PrintDetails()
    {
        base.PrintDetails();
        Console.WriteLine("Selling price: {0}", this.GetPrice());
    }
}

class Chocolate : Product
{
    private double _profit;
    //parameterized constructor
    public Chocolate(string name, double price)
        : base(name, price)
    {
        this._profit = base.GetPurchasePrice() * 0.20;
    }

    // public method to get selling price
    public override double GetPrice()
    {   //calculating selling price, Math.ceiling is just an ibuilt method to round off the price
        return (base.GetPurchasePrice() + (int)Math.Round(this._profit));
    }

    public override void PrintDetails()
    {
        base.PrintDetails();
        Console.WriteLine("Selling price: {0}", this.GetPrice());
    }
}

class Demo
{
    public static void Main(string[] args)
    {
        //placing the products in an array
        Product[] products = new Product[2];
        products [0] = new Beverage("Cola", 9);
        products [1] = new Chocolate("Crunch", 15);
        foreach(Product product in products)
        product.PrintDetails();
    }
}