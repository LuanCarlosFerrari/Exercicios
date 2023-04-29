using Microsoft.EntityFrameworkCore;

public class MeuContexto : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=myhost;Database=mydatabase;Username=myuser;Password=mypassword");
    }

    public DbSet<MeuModelo> MeusModelos { get; set; }
}