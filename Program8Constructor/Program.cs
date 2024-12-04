class LaptopMachine
{
    private bool _onOff;
    private int _maxStorage;
    private int _storage;
    private int _uptime;

    public LaptopMachine() 
    {// a parameter-less constructor implemented
        _onOff = false;
        _maxStorage = 1000;
        _storage = 0;
        _uptime = 0;
    }

    public LaptopMachine(bool onOff, int storage, int uptime)
    {
        _onOff = onOff;
        _maxStorage = 1000;
        _uptime = uptime;
        if(storage >= 0 && storage <= _maxStorage){
            _storage = storage;
        }
        else Console.WriteLine("Invalid storage value");
    }

    public void PrintFields(){
        Console.WriteLine("is the laptop turned on? {0}", _onOff);
        Console.WriteLine("The storage of the device is: {0}", _storage);
        Console.WriteLine("the storage capacity of the device {0}", _maxStorage);
        Console.WriteLine("the duration of the uptime of the computer is {0}", _uptime);
    }
}

class Program
{
    public static void Main(string[] args){
        //passing the parameters
        // var laptopMachine = new LaptopMachine(true, 500, 3000);
        // laptopMachine.PrintFields();

        //invalid validation
        var laptop = new LaptopMachine(false, 1200, 2500);
        laptop.PrintFields();
    }
}