class Student 
{
    //Declare the fields and properties here
    public string Name {get; set;}
    public double PhysicsMark {get; set;}
    public double ChemistryMark {get; set;}
    public double BioMark {get; set;}
    public double Total {get; set;}
    public double Percentage {get; set;}


    // Modify the below constructor
    public Student(string name, double physicsMark, double chemistryMark, double bioMark)
    {
        //write definition here
        Name = name;
        PhysicsMark = physicsMark;
        ChemistryMark = chemistryMark;
        BioMark = bioMark;
    }

    public double TotoalObtained(){
        // write definition here
        Total = PhysicsMark + ChemistryMark + BioMark; 
        return Total;
    }

    public double GetPercentage(){
        // write definition here
        Percentage = Total/300 *100; 
        return Percentage;
    }
}
class Demo{
    public static void Main(string[] args){
        Student john = new Student("John", 56, 56, 85);
        Console.WriteLine(john.TotoalObtained());
        Console.WriteLine(john.GetPercentage());
    }
}