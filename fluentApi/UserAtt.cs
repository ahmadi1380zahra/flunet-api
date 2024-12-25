using System.ComponentModel.DataAnnotations.Schema;

namespace fluentApi;

public class UserAtt
{
    public int Id { get; set; }
    public int Age {
        get;
        set;
    }

    public DateTime BirthDate { get; set; }
    [NotMapped]
    public string dummy { get; set; }
}