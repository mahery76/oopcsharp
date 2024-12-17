abstract class EDM{
    public EDM() {
        //parameter-less constructor
    }
    public abstract void Transact(bool successful);

    public void Dispense(){
        Console.WriteLine("{0} is dispensing the product!", this.GetType().Name);
    }
}
interface ICanPrint{
    void PrintReceipt();
}

class CashVendingMachine : EDM, ICanPrint{ //Inherits from EDM, Implements ICanPrint
    public override void Transact(bool successful){
        if(successful){
            Console.WriteLine("The transaction was successfully completed");
            PrintReceipt();
        }
        else Console.WriteLine("The transaction was unsuccessfull!");
    }
    public void PrintReceipt() {
        Console.WriteLine("Printing your receipt...");
    }
}

class Demo{
    public static void Main(string[] args){
        EDM cashVendy = new CashVendingMachine();

        cashVendy.Dispense();
        cashVendy.Transact(true);
        Console.WriteLine();
        cashVendy.Transact(false);
    }
}