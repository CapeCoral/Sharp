namespace TheNote.Models;

public class Note
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Text { get; set; }
    public DateTime CreatedDate { get; set; }
    public List<string> Tags { get; set; }
}
