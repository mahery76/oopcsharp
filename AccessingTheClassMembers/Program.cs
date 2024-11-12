using System;
using EducativeIo.AccessingTheClassMembers;

namespace AccessingTheClassMembers;

public class Program
{
    public static void Main(string[] args)
    {
        var LaptopMachine = new LaptopMachine();
        Console.WriteLine("the storage of the machine is: {0}", LaptopMachine.storage);
        LaptopMachine.Recharge();

        var Mouse = new LaptopMachine.Mouse();
        Mouse.Click();
    }
}
