public class Students
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Id_Group { get; set; }
    public int Term {  get; set; }
    public ICollection<S_Cards> Cards { get; set; }
    
    //Navigation
    public Groups Groups { get; set; }
}
