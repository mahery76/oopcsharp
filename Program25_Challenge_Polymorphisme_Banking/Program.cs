// Implement classes here
class Account 
{
  private double _balance;

  protected double Balance{
    get {return this._balance;}
    set {if(value>=0) this._balance = value;}
  }

  public Account(double balance){
    this.Balance = balance;
  }



  public virtual bool Withdraw(double amount){
    return false;
  }
  public virtual bool Deposit(double amount)
  {
    return false;
  }
  public virtual void PrintBalance()
  {
    Console.WriteLine("The balance is: " + Balance);
  }
}

class SavingsAccount : Account
{
  private double _interestRate;

  // constructor
  public SavingsAccount(double balance)
  : base(balance) // this "balance initialize the Balance field in the base class"
  { // it is always preferable to initialize fields inside a constructor
    this._interestRate = 0.8;
  }

  public override bool Deposit(double amount)
  {
    if(amount <= 0){
      return false;
    }
    balance = balance + (amount +(amount * this._interestRate));
    return true;
  }

  public override bool Withdraw(double amount)
  {
    if(amount <= 0){
      return false;
    }
    balance = balance - (amount +(amount * this._interestRate));
    return true;
  }

  public overrid void PrintBalance(){
    Console.WriteLine("The saving account balance is: "+ base.Balance);
  }
}

class CheckingAccount : Account
{
  public CheckingAccount(double balance)
  : base(balance){}

  public override bool Deposit(double amount){
    if(amout > 0)
    {
      Balance += amount;
      return true;
    }
    return false;
  }
  public override void PrintBalance(){
    Console.WriteLine("The checking account balance is: " + base.Balance);
  }


  
}

class Demo {

  public static void Main(string[] args) {

      // Creating saving account object
      Account SAccount = new SavingsAccount(5000);
      SAccount.Deposit(1000);
      SAccount.PrintBalance();

      SAccount.Withdraw(3000);
      SAccount.PrintBalance();

      Console.WriteLine();

      // Creating checking account object
      Account CAccount = new CheckingAccount(5000);
      CAccount.Deposit(1000);
      CAccount.PrintBalance();

      CAccount.Withdraw(3000);
      CAccount.PrintBalance();
  }

}