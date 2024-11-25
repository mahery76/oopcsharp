using System;

namespace oopcsharp.Program5StaticAndNonStaticMethods;

class Program {
    public static void Main (string[] args){
        // if PrintManufacturer() is static
        // LaptopMachine.PrintManufacturer();

        // if PrintManufacturer() not static
        var LaptopMachine = new LaptopMachine();
        LaptopMachine.PrintManufacturer();

    }
}
