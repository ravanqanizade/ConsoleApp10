public class AudioBook
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Pages { get; set; }
    public int Author_Id { get; set; }
    
    //Navigation
    public Authors Authors {  get; set; } 
}