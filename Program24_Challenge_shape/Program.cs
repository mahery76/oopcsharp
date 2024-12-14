class Shape 
{
    // public Shape()
    // {
        
    // }
    public virtual double CalcArea()
    {
        return 0;
    }
}

// Derived Class
class Circle : Shape { 
  
  private double _radius; // Uncomment this line
  
  public Circle(double radius) { // Parameterized Constructor
    this._radius = radius;     // Uncomment this line
  }
  
  // Override the Method CalcArea() which returns the area of a Circle
  public override double CalcArea()
  {
    double area = this._radius * this._radius * 3.14;
    return area;
  }
}
class Demo
{
    public static void Main (string[] args)
    {
        Shape circle = new Circle(2);
        Console.WriteLine(circle.CalcArea());
    }
}