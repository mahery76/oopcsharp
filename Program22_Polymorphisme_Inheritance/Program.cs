class Product 
{
    private string _name;
    private double _purchasePrice;

    public Product(string name, double purchasePrice)
    {
        this._name = name;
        this._purchasePrice = purchasePrice;
    }
    //getter to access the purchase price of products
    public double GetPurchasePrice()
    {
        return this._purchasePrice;
    }
    // Method GetPrice() to be re-implemented in the derived classes
    public virtual double GetPrice()
    {
        return 0;
    }
    // method to print name and to be re-implemented in the derived classes for selling price
    public virtual void PrintDetails()
    {
        Console.WriteLine("Selected Product's name: " + this._name);
    }
}

class Beverage : Product
{
    // private fields for refrigeration cost and our profit
    private double _refCost;
    private double _profit;
    public Beverage(string name, double price)
    : base(name, price)
    {
        this._refCost = GetPurchasePrice() * 0.10;   // 10% of purchase price
        this._profit = GetPurchasePrice() * 0.15;// 15% of purchase price
    }
    // public method to get selling price
    public override double GetPrice()
    {
        return (GetPurchasePrice() + (int)Math.Round(this._refCost) + (int)Math.Round(this._profit));
    }

    // public method to call the base method for name and print the selling price from this class
    public override void PrintDetails()
    {
        base.PrintDetails();
        Console.WriteLine("Selling price: {0}", this.GetPrice());
    }
}

class Chocolate : Product
{
    private double _profit;
    public Chocolate(string name, double price)
    : base(name, price)
    {
        this._profit = base.GetPurchasePrice() * 0.20;// 20% of purchase price
    }
    //public method to get selling price
    public override double GetPrice()
    {
        //calculating selling price
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
        Product[] products = new Product[2];
        products [0] = new Beverage("Cola",9);
        products [1] = new Chocolate("Crunch", 15);

        foreach(Product product in products)
        {
        product.PrintDetails();
        }
        
    }
}

// product(name, purchasePrice)
// - _name
// - _purchasePrice

// - GetpurchasePrice  = () => return _purchasePrice
// - GetPrice = () => return 0
// - PrintDetails = () => output("_name")


// Beverage:Product (name, price)
// - _refCost = GetpurchasePrice * 0.10
// - _profit = GetpurchasePrice * 0.15

// - GetPrice = () => return (GetpurchasePrice + _refCost + _profit)
// - PrintDetails = () => output("getPrice()")

// Chocolate:Product(name, price)
// - _profit = GetpurchasePrice * 0.20

// - GetPrice = () => (GetpurchasePrice + _profit)
// - PrintDetails = () => output("getPrice()")



