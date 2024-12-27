public class Product 
{
    private string _name;
    private double _price;
    public Product(string name, double price)
    {
        this._name = name;
        this._price = price;
    }
    public void PrintDetails()
    {
        Console.Write("[{0} {1}]\t\t", this._name, this._price);
    }
}

class VendingMachine
{
    private Product[] _productShelf;
    private int _capacity;
    private static int _productCount;

    public VendingMachine()
    {
        this._productShelf = new Product[2];
        this._capacity = 2;
        _productCount = 0;
    }

    public bool InsertProduct(Product item)
    {
        if(_productCount < _capacity)
        {
            this._productShelf[_productCount] = item;
            _productCount++;
            return true;
        }
        else 
        {
            return false;
        }
    }
    public void PrintProducts()
    {
        for (int i = 0; i< this._capacity; i++)
        {
            _productShelf[i].PrintDetails();
        }
    }
}

class Demo
{
    public static void Main(string[] args)
    {
        VendingMachine myVendy = new VendingMachine();

        // creating products
        Product snack = new Product("Rango tango", 0.5);
        Product drink = new Product("Crunchy", 1);

        //inserting products into machine
        myVendy.InsertProduct(snack);
        myVendy.InsertProduct(drink);

        //printing the product in vending machine
        myVendy.PrintProducts();

        //null vending machine object
        myVendy = null;

        // the product still exist;
        snack.PrintDetails();
        drink.PrintDetails();
    }
}