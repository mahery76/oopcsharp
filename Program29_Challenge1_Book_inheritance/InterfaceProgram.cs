interface IBook {
  string Name { get; }
  string Author { get; }
  string Price { get; }

  string GetDetails();
}

// Class MyBook implementing IBook interface
class MyBook : IBook {
  // Private Fields
  private string _name;
  private string _author;
  private string _price;

  // Properties
  public string Name {
    get { return this._name; }
  }

  public string Author {
    get { return this._author; }
  }

  public string Price {
    get { return this._price; }
  }

  // Parameterized Constructor
  public MyBook(string name, string author, string price) {
    this._name = name;
    this._author = author;
    this._price = price;
  }

  // Implementing the GetDetails Method from the IBook Interface
  public string GetDetails() {
    return Name + Author + Price;
  }
}

class Demo{
  public static void Main(string[] args)
  {
    IBook myBook = new MyBook("Harry Potter", "J.k Rowling", "200");
    Console.WriteLine(myBook.GetDetails());
  }
}
