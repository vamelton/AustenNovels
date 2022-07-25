using Microsoft.EntityFrameworkCore;
using AustenNovels.Models;
using System.Text.Json;

public class Context : DbContext
{

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        List<Books> books = new List<Books>();

        using (StreamReader p = new StreamReader("BookSeedData.json"))
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
                    Biography = book.Biography
                }
            );
        }
        base.OnModelCreating(modelBuilder);
    }
}
