public class Faculties
{
    public int Id { get; set; }
    public string Name { get; set; }
    public ICollection<Groups> Groups { get; set; }
}