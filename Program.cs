

Person[] peopleInClassroom =
{
    new Lehrer("John", "Smith", 32),
    new Student("Sabrina", "Müller", 18),
    new Student("Anna", "Matt", 17),
    new Student("Peter", "Fredl", 18),
    new Student("Matthias", "Maier", 19)
};
foreach(Person p in peopleInClassroom)
{
    p.printInformation();

    if(p is Lehrer)
    {
        (p as Lehrer).Teach();
    }
    else if ( p is Student)
    {
        (p as Student).ListenToTeacher();
    }

    Console.WriteLine();
}

Console.ReadKey();
public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public byte Age { get; set; }


    public Person(string firstName, string lastName, byte age)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;

    }
    public void printInformation()
    {
        Console.WriteLine("Name: " + FirstName + " " + LastName);
        Console.WriteLine("Alter: " + Age);
    }



}
class Lehrer : Person
{
    public Lehrer(string firstName, string lastName, byte age) : base(firstName, lastName, age)
    {
        firstName = FirstName;
        lastName = LastName;
        age = Age;
    }

    public void Teach()
    {
        Console.WriteLine("Herr/Frau {0} unterrichtet die Klasse!", LastName);
    }

}
class Student : Person
{
    public Student(string firstName, string lastName, byte age) : base(firstName, lastName, age)
    {
        firstName = FirstName;
        lastName = LastName;
        age = Age;
    }

    public void ListenToTeacher()
    {
        Console.WriteLine("Der/Die Schüler/in {0} {1} hört dem Lehrer zu!", FirstName, LastName);
    }
}

