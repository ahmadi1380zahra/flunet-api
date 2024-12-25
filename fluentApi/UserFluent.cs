namespace fluentApi;

public enum Gender
{
    Girl=1,
    Boy=2,
    Unknown=3
}

public class NationalCode
{
    public NationalCode(string code)
    {
        PersonalCode = code;
    }
    public string PersonalCode { get; private set; }
}

public class FullName
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}
public class UserFluent
{
    public int Id { get; set; }
    public int Age {
        get;
        set;
    }

    public DateTime BirthDate { get; set; }
    public string Dummy { get; set; }
    public Gender Gender { get; set; }
    public NationalCode NationalCode { get; set; }
    public FullName FullName { get; set; }
}