namespace oopcsharp.Program7GettersSetters;

class LaptopMachineProperties
{
    private int _memory = 8;
    private int _maxmemory = 16;

    // implementing the count property
    public int Memory{
        get{
            return _memory;
        }
        set{
            if(value >= 0 && value <= _maxmemory)
            _memory = value;
        }
    }
}

