using Microsoft.EntityFrameworkCore;
using AustenNovels.Models;
using System.Text.Json;


public class Context : DbContext
{

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        // connect to sqlite database
        options.UseSqlite(@"Data Source=books.db");

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        List<Books> books = new List<Books>();

        using (StreamReader p = new StreamReader("json.json")) 
        {
            string json = p.ReadToEnd();
            books = JsonSerializer.Deserialize<List<Books>>(json);
        }
        foreach (Books book in books)
        {
            modelBuilder.Entity<Books>().HasData(
                new Books
                {
                    ID = book.ID,
                    Title = book.Title,
                    PublishedYear = book.PublishedYear,
                    Characters = book.Characters,
                    Summary = book.Summary,
                    
                }
            );
        }
        base.OnModelCreating(modelBuilder);
    }
    public DbSet<Books> Books { get; set; }
}
