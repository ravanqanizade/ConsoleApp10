public class Books
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Pages { get; set; }
    public int YearPress { get; set; }
    public int Id_Themes { get; set; }
    public int Id_Category { get; set; }
    public int Id_Author { get; set; }
    public int Id_Press { get; set; }
    public string Comment { get; set; }
    public int Quantity { get; set; }

    public ICollection<S_Cards> SCards { get; set; }
    public ICollection<T_Cards> TCards { get; set; }

    //Navigation

    public Authors Authors { get; set; }
    public Press Press { get; set; }
    public Themes Themes { get; set; }
    public Categories Categories { get; set; }
}