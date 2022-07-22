using Microsoft.EntityFrameworkCore;
using AustenNovels.Models;

public class Context : DbContext
{

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        // connect to sqlite database
        options.UseSqlite(@"Data Source=test.db");
    }
   
   public DbSet<Books> AustenNovels {get; set;}
}
