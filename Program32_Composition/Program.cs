using System;
public class Display 
{
    public void ShowMessage(string message)
    {
        Console.WriteLine(message);
    }
    public Display(){}
    public void WelcomeMessage() {
        Console.WriteLine("Welcome to the vending machine");
    }
    public void DisplayMethod()// Method to show the machine menu
    {
        Console.Write(@"
.-----.---------------------.
|Press|       Action        |
|-----|---------------------|
|  1  |    Feed Money       |
|  2  |    Select a Product |
|  3  |    Get Change       |
|  4  |    Quit             |
'-----'---------------------'
        ");
    }
}
public class KeyPad {
    public KeyPad(){}
    public int ReadKey()// method to read the user input
    {
        string userInput;
        userInput = Console.ReadLine();
        // convert to integer type as the keypad should only have integer input 
        int value;
        if(int.TryParse(userInput, out value) && value > 0)
        {
            return value;
        }
        else return -1;
    }
}
public class VendingMachine { // Owner class
    // Fields of VendingMachine class
    private Display _machineDisplay;
    private KeyPad _machineKeyPad;
    //Constructor of VendingMachine class
    public VendingMachine(){
        // creating owned objects
        this._machineDisplay = new Display();
        this._machineKeyPad = new KeyPad();
    }
    public void DisplayMessage(string message)
    {
        _machineDisplay.ShowMessage(message);
    }

    //Method to read user input
    public int GetUserInput()
    {
        return _machineKeyPad.ReadKey();
    }
    /* The above Display and KeyPad objects can be used here*/
}

class Program 
{
    static void Main(string[] args)
    {
        VendingMachine vendingMachine = new VendingMachine();
        vendingMachine.DisplayMessage("Welcome please enter a number");
        int userInput = vendingMachine.GetUserInput();
        vendingMachine.DisplayMessage("You entered: " + userInput);
    }
}