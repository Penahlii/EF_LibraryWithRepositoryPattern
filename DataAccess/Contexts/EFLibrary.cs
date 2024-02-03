#nullable disable

using DBCodes.Entities.Concretes.Cards;
using DBCodes.Entities.Concretes.HumanBeing;
using DBCodes.Entities.Concretes.RelatedToBook;
using DBCodes.Entities.Concretes.RelatedToLibrary;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DataAccess.Contexts;

internal class EFLibrary : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var ConnectionString = new ConfigurationManager()
            .AddJsonFile("C:\\Users\\asus\\source\\repos\\EntityFrameworkHW3\\DataAccess\\AppSettings\\AppSettings.json")
            .Build()
            .GetConnectionString("DefaultConnection");

        optionsBuilder
            .UseLazyLoadingProxies()
            .UseSqlServer(ConnectionString);

        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        base.OnModelCreating(modelBuilder);
    }

    public virtual DbSet<S_Card> S_Cards { get; set; }
    public virtual DbSet<T_Card> T_Cards { get; set; }
    public virtual DbSet<Author> Authors { get; set; }
    public virtual DbSet<Lib> Libs { get; set; }
    public virtual DbSet<Student> Students { get; set; }
    public virtual DbSet<Teacher> Teachers { get; set; }
    public virtual DbSet<Book> Books { get; set; }
    public virtual DbSet<Category> Categories { get; set; }
    public virtual DbSet<Press> Presses { get; set; }
    public virtual DbSet<Theme> Themes { get; set; }
    public virtual DbSet<Department> Departments { get; set; }
    public virtual DbSet<Faculty> Faculties { get; set; }
    public virtual DbSet<Group> Groups { get; set; }
}