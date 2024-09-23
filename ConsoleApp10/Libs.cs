public class Libs
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public ICollection<S_Cards> SCards { get; set; }
    public ICollection<T_Cards> TCards { get; set; }
}
