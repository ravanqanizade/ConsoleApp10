public class Departments
{
    public int Id { get; set; }
    public string Name { get; set; }
    public ICollection<Teachers> Teachers { get; set; }
}
