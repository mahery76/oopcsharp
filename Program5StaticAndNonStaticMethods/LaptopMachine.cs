using System;

namespace oopcsharp.Program5StaticAndNonStaticMethods;
class LaptopMachine
{
    static string manufacturer = "Dell";
    private int _storage = 512;

    // public static void PrintManufacturer() {
    //     Console.WriteLine("The manufacturer of this laptop is {0}", manufacturer);
    // }
    public void PrintManufacturer() {
        Console.WriteLine("The manufacturer of this laptop is {0}", manufacturer);
    }

    
}   