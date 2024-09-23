public class Themes
{
    public int Id { get; set; }
    public string Name { get; set; }
    public ICollection<Books> Books { get; set; }
}