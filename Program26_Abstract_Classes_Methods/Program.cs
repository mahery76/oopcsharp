abstract class EDM{
    public EDM(){
        // parameter-less constructor
    }
    public abstract void Transact();
    public void Dispense(){
        Console.WriteLine("{0} is dispensing the product!",this.GetType().Name);
    }
}

class CardVendingMachine : EDM {
    public override void Transact(){
        Console.WriteLine("I accept cards only!");
    }
}
class CashVendingMachine : EDM {
    public override void Transact(){
        Console.WriteLine("I accept cash only!");
    }
}
class HybridVendingMachine : EDM{
    public override void Transact(){
        Console.WriteLine("I accept both cards and cash!");
    }
}

class Demo {
    public static void Main(string[] args)
    {
        EDM cardVendy = new CardVendingMachine();
        EDM cashVendy = new CashVendingMachine();
        EDM hybridVendy = new HybridVendingMachine();

        cardVendy.Dispense();    // Calling methods from CardVendingMachine
        cardVendy.Transact();

        cashVendy.Dispense();
        cashVendy.Transact();

        hybridVendy.Dispense();
        hybridVendy.Transact();
    }
}