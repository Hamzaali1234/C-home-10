namespace Domain;

public class Post
{
    public int Id{get;set;}
    public string Title{get;set;} = null!;
    public string Description{get;set;} = null!;
    public int VoteAmount{get;set;}
    public DateTime Createdal{get;set;}
}
