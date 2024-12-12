using System;

class Product {
    private string name;
    private double price;

    public string GetName(int liters)
    {
        if(liters == 1){
            this.name = "cola";
            return this.name;
        }
        else if (liters == 2){
            this.name = "fanta";
            return this.name;
        }
        else if (liters == 3){
            this.name = "Dew";
            return this.name;
        }
        else return "";
    }
    public double GetPrice(int liters)
    {
        if(liters == 1)
        {
            this.price = 2;
            return this.price;
        }
        else if (liters == 2){
            this.price = 3.5;
            return this.price;
        }
        else if(liters == 3){
            this.price = 4;
            return this.price;
        }
        else return 0;
    }
}

class Beverage : Product{
    public int Liters {get; set;}

    public string GetDetails(){
        string details = GetName(this.Liters) + ", "+GetPrice(this.Liters) + ", "+ this.Liters;
        return details;
    }
}


class Demo {
    public static void (string[] args){
        Beverage beverage = new Beverage();
        beverage.Liters = 2;
        Console.WriteLine(beverage.GetDetails());
    }
}