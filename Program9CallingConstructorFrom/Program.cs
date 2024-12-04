class Laptop{
    private bool _onOff;
    private int _count;
    private int _storateCapacity = 100;
    private int _dataCollected;

    // A parameterless constructor implemented
    public Laptop(){
        // use of this keyword on the left side of = operator
        this._onOff = false;
        this._count = 0;
        this._dataCollected = 0;
    }

    // A parametrized constructor implemented
    public Laptop(bool onOff, int count){
        // use of this keyword on the left side of = operator
        this._onOff = onOff;
        this._count = count;
    }

    public Laptop(bool onOff, int count, int dataCollected)
    //calling the above parameterized constructor
    : this(onOff, count) 
    {
        this._dataCollected = dataCollected;
    }

    public void PrinFields(){
        Console.WriteLine("Is the laptop turned on? {0}", this._onOff);
        Console.WriteLine("The count of product is {0}", this._count);
        Console.WriteLine("The storage of the machine is {0}", this._storateCapacity);
        Console.WriteLine("The total size of the data is {0}", this._dataCollected);
    }
}
class Demo{
    public static void Main(string[] args){
        // Object created with parameterized constructor!
        var laptop1 = new Laptop(true, 5, 250);

        // Object created with parameterized constructor!
        var laptop2 = new Laptop(true, 5);

        // Object created with parameter-less constructor!
        var laptop3 = new Laptop();

        laptop1.PrinFields();
        laptop2.PrinFields();
        laptop3.PrinFields();
    }
}