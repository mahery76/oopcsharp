class Rectangle 
{
    // Declare fields here
    private int _length;
    private int _width;

    public Rectangle(int length, int width){
        this._length = length;
        this._width = width;
    }

    public int GetArea(){
        return this._length * this._width;
    }
}
class Program 
{
    public static void Main(string[] args)
    {
        Rectangle obj = new Rectangle(5, 7);
        Console.WriteLine(obj.GetArea());
    }
}