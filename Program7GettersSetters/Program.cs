namespace oopcsharp.Program7GettersSetters;
class Demo{
    public static void Main(string[] args){
        // natural laptop machine getter and setter implementations
        var laptopMachine = new LaptopMachine();
        laptopMachine.SetMemory(16);
        Console.WriteLine("Using natural method, the memory is: {0}", laptopMachine.GetMemory());

        // Laptop machine getter and setter with property implementations
        var laptopMachineProperty = new LaptopMachineProperties();
        laptopMachineProperty.Memory = 12;
        Console.WriteLine("Using property, the memory is: {0}", laptopMachineProperty.Memory);
        
        // Laptop machine getter and setter with auto implemented properties 
        var laptopMachineAutoProperties = new LaptopMachineAutoProperties();
        laptopMachineAutoProperties.Memory = 24;
        Console.WriteLine("Using auto property, the memory is: {0}", laptopMachineAutoProperties.Memory);
    }
}