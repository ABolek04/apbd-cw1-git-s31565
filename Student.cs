namespace DefaultNamespace;

public class Student
{
    public Student(int ID, string Name)
    {
        this.ID = ID;
        this.Name = Name;
    }

    public Student()
    {
        
    }
    public int ID { get; set; }
    public string Name { get; set; }
}