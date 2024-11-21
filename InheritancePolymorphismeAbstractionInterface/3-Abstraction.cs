//abstract class
abstract class Animal
{
    // abstract method does not have a body
    public abstract void animalSound();

    // regular method
    public void sleep()
    {
        Console.WriteLine('zzz');
    }
}

// Derived class (inherit from Animal)
class Pig: Animal
{
    public override void animalSound()
    {
        Console.WriteLine('the pig says wee wee');
    }
}

// the main class 
class Program 
{
    static void Main(string[] args)
    {
        Pig myPig = new Pig();
        myPig.animalSound();
        myPig.sleep();
    }
}