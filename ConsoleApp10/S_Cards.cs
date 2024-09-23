public class S_Cards
{
    public int Id { get; set; }
    public int Id_Student { get; set; }
    public int Id_Book { get; set; }
    public DateTime DateOut { get; set; }
    public DateTime DateIn { get; set; }
    public int Id_Lib { get; set; }
    
    //Navigation
    public Books Books { get; set; }
    public Students Students { get; set; }
    public Libs Libs { get; set; }
}
