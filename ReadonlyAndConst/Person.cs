namespace ReadonlyAndConst;

public class Person
{
    private readonly string _firstName;
    private readonly string _lastName;
    
    private const int MaxNumbOfAge = 150; //for sample

    public Person(string firstName, string lastName)
    {
        _firstName = firstName;
        _lastName = lastName;
    }

    public void Print()
    {
        Console.WriteLine($"firstName: {_firstName} lastName: {_lastName}");
    }
}