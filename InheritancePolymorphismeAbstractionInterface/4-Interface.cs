interface IAnimal
{
    void animalSound();
}

class Pig: IAnimal
{
    public void animalSound()
    {
        Console.WriteLine("the pig says: wee wee");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Pig myPig = new Pig();
        myPig.animalSound();
    }
}