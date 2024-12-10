// base product
class Product 
{
    public double price = 1.7;

    public void Display(){
        Console.WriteLine("I am from the base class");
    }
}
class Beverage : Product {
    new double price = 1;
    new public void Display(){
        Console.WriteLine("I am from the derived class");
    }
    public void DisplayAll(){
        Console.WriteLine("Price from Product class: " + base.price);
        Console.WriteLine("price from Beverage Class: " + this.price);

        base.Display();
        Display();

    }
}
class Demo 
{
    public static void Main(String[] args)
    {
        Beverage cola = new Beverage();
        // cola.DisplayAll();
    }
}