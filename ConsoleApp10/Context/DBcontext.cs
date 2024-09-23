using Microsoft.EntityFrameworkCore;

public class DBcontext:DbContext
{
    public DbSet<Authors> _authors { get; set; }
    public DbSet<Press> _press { get; set; }
    public DbSet<Categories> _categories { get; set; }
    public DbSet<Themes> _themes { get; set; }
    public DbSet<Books> _books { get; set; }
    public DbSet<S_Cards> _s_cards { get; set; }
    public DbSet<Students> _students { get; set; }
    public DbSet<Faculties> _faculties { get; set; }
    public DbSet<Groups> _groups { get; set; }
    public DbSet<Teachers> _teachers { get; set; }
    public DbSet<T_Cards> T_Cards { get; set; }
    public DbSet<Libs> _libs { get; set; }
    public DbSet<Departments> _departments { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=FOSSIGREM\\MSSQLSERVER01;Initial Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        base.OnConfiguring(optionsBuilder);
    }
}