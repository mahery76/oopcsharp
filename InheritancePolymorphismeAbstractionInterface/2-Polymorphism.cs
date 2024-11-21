class Animal // Base class
{
    public virtual void animalSound()
    {
        Console.WriteLine("The animal makes a sound");
    }
}
class Pig : Animal 
{
    public override void animalSound()
    {
        Console.WriteLine("wee wee")
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal myAnimal = new Animal();
        Pig myPig = new Pig();

        myAnimal.animalSound();
        myAnimal.animalSound();
    }
}