public class T_Cards
{
    public int Id { get; set; }
    public int Id_Teacher { get; set; }
    public int Id_Book { get; set; }
    public DateTime DateOut { get; set; }
    public DateTime DateIn { get; set; }
    public int Id_Lib { get; set; }

    //Navigation

    public Books Books { get; set; }
    public Libs Libs { get; set; }
    public Teachers Teachers { get; set; }
}
