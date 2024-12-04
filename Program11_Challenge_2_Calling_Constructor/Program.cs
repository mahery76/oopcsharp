// vending machine class
class VendingMachine
{
    //private fieds
    private string _count;
    private string _capacity;
    private string _moneyCollected;

    //default constructor
    public VendingMachine()
    {
        this._count = "";
        this._capacity = "";
        this._moneyCollected = "";
    }

    //parametrized constructor 1
    public VendingMachine(string count, string capacity)
    {
        this._count = count;
        this._capacity = capacity;
    }
    public VendingMachine(string count, string capacity, string money)
    : this(count, capacity)
    {
        this._moneyCollected = money;
    }
    public string GetDetails() {
        return this._count + ", " + this._capacity + ", " + this._moneyCollected;
    }
}