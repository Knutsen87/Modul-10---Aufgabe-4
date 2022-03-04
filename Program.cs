

class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public byte Age { get; set; }

    
    public Person (string firstName, string lastName, byte age)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;


        static void printInformation(string firstName, string lastName, byte age)
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
            Console.WriteLine("Alter: " + age);
        }
        printInformation(firstName, lastName, age);
    }



}

