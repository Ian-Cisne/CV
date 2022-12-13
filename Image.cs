namespace CV;

public class Image
{
    public Image(DateTime creationDate, string title){
        this.CreationDate = creationDate;
        this.Title = title;
    } 
    public DateTime CreationDate { get; }

    public string? Title { get;  }
}
