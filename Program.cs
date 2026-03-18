namespace DefaultNamespace;

public class Program
{
    public static void Main()
    {
        Student s = new Student();
        s.ID = 10;
        s.Name = "Adam";
        Console.WriteLine(s.Name);
        Student s2 = new Student(15,"Adam2");
        Console.WriteLine(s2.ID);
    }
}


