// class LaptopMachine{
//     private int moneyCollected = 70;
//     public void PrintMoney(int moneyCollected){
//         Console.WriteLine("Money collected using this variable: " + this.moneyCollected);
//         Console.WriteLine("Money collected without using this variable: " + moneyCollected);
//     }
// }

// class Demo {
//     public static void Main(string[] args){
//         var LaptopMachine = new LaptopMachine();
//         LaptopMachine.PrintMoney(-10);
//     }
// }

class Score {
    private int _num;
    public Score(){
        this._num = num;
    }
    public int GetNum(){
        return this._num;
    }
}
class Demo{
    public static void Main(string[] args){
        var sc = new Score(5);
        System.Console.WriteLine(sc.GetNum());
    }
}