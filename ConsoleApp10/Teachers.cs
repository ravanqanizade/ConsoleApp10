public class Teachers
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Id_Dep {  get; set; }
    public ICollection<T_Cards> Cards { get; set; }
    
    //Navigation
    public Departments Departments { get; set; }
}
