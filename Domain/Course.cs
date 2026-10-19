namespace Domain;

public class Course
{
    public int Id{get;set;}
    public string Title{get;set;} = null!;
    public string Description{get;set;} = null!;
    public decimal Free{get;set;}
    public bool HasDiscount{get;set;}
}
