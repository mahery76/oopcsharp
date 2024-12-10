class Product {
    // Private Fields: Common attributes of all type of products
    private string _name;
    private double _price;
    private string _expiryDate;

    //parameterized constructor
    public Product(string name, double price, string expiryDate){
        this._name = name;
        this._price = price;
        this._expiryDate = expiryDate;
    }
    //public method to print details
    public void PrintDetails(){
        Console.WriteLine("Name: "+ this._name);
        Console.WriteLine("price: "+ this._price);
        Console.WriteLine("Expiry date: "+ this._expiryDate);
    }
}

class Beverage: Product{

    private double _litres;
    private string _flavor;

    //Parameterized Constructor
    public Beverage(string name, double price, string expiryDate, double litres, string flavor)
    : base(name, price, expiryDate) // calling parent class constructor

    {
        this._litres = litres;
        this._flavor = flavor;
    }
    public void BeverageDetails(){
        PrintDetails();
        //priting the fields of this class
        Console.WriteLine("Litres: " + this._litres);
        Console.WriteLine("Flavor: " + this._flavor);
    }
}
class Demo{
    public static void Main(string[] args){
        Beverage cola = new Beverage("World Cola", 2000,"8/11/2021", 0.35, "Lemon");
        cola.BeverageDetails();// calling the method to print details 
    }
}