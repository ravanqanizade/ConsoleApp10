public class Authors
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public ICollection<Books> Books { get; set; }
    public ICollection<AudioBook> AudioBooks { get; set; }
}