namespace oopcsharp.Program7GettersSetters;
class LaptopMachine 
{
    private int _memory = 8;
    private int _maxmemory = 16;

    public void SetMemory(int x){
        if(x >=0 && x <= _maxmemory){   
            _memory = x;
        }
    }

    public int GetMemory(){
        return _memory;
    }
}