class MoneyCollector
{
    private int moneyCollected;
    private int productPrice;
    private int insertedMoney;
    
    // public int moneyCollected;
    // public int productPrice;
    // public int insertedMoney;
    public MoneyCollector()
    {
        this.moneyCollected = 0;
        this.productPrice = 2;
        this.insertedMoney = 0;
    }

    public void AddMoney(int money)
    {
        this.insertedMoney = money;
        if (this.insertedMoney >= 0)
        {
            Console.WriteLine("You inserted {0}$", this.insertedMoney);
            this.Change();
        }
        else
            Console.WriteLine("invalid insertion");
        this.insertedMoney = 0;
    }

    public void Change()
    {
        if (this.insertedMoney >= this.productPrice)
        {
            int change = this.insertedMoney - this.productPrice;
            this.moneyCollected += this.productPrice;
            Console.WriteLine("Your change is: {0}$", change);
        }
        else
        {
            Console.WriteLine("You didn't insert the sufficient money");
            // the transaction was not successfull so return back the money
            Console.WriteLine("Your change is: {0}$", this.insertedMoney);
        }
    }

    public int GetMoneyCollected()
    {
        return this.moneyCollected;
    }
}

class Demo
{
    public static void Main(string[] args)
    {
        // create a new money collector object
        var moneyCollector = new MoneyCollector();
        // 3 customers purchase products
        moneyCollector.AddMoney(2);
        moneyCollector.AddMoney(3);
        moneyCollector.AddMoney(7);
        // getting the collected as 3 products sold it should be 2*3 = 6
        Console.WriteLine(
            "Total collection till now is : {0}$",
            moneyCollector.GetMoneyCollected()
        );

        // trying the corrupt the collection
        moneyCollector.moneyCollected = 45;
        Console.WriteLine(
            "Total collection till now is : {0}$",
            moneyCollector.GetMoneyCollected()
        );
        //The collection was public so we easily changed its value
        //THIS SHOULD NOT HAVE HAPPENED!
    }
}
