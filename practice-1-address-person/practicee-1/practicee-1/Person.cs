namespace practicee_1;

public class Person
{
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string LastName { get; set; }
    public Address PresentAddress { get; set; }
    public string GetFullName()
    {
        string FullName = FirstName + "" + MiddleName + "" + LastName;
        return FullName;
    }

}
