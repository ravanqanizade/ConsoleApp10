public class Groups
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Id_Faculty { get; set; }
    public ICollection<Students> Students { get; set; }

    //Navigationx   
    public Faculties Faculties { get; set; }
}