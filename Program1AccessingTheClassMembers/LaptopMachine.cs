using System;

namespace Program1AccessingTheClassMembers;

public class LaptopMachine
{
    public class Mouse
    {
        public void Click()
        {
            Console.WriteLine("The mouse is just clicked");
        }
    }
    public int count = 20;
    public int storage = 512;
    public int price = 750;
    public string manufacturer = "Dell";

    public void TurnOn()
    {
        Console.WriteLine("Computer is starting");
    }

    public void Restart()
    {
        Console.WriteLine("Computer is restarting");
    } 
    public void Recharge()
    {
        Console.WriteLine("Computer is charging");
    }

}
