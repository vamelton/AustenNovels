using Microsoft.EntityFrameworkCore;
using AustenNovels.Models;

namespace Context;
public class Context : DbContext
{
   public Context() : base(){}
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        // connect to sqlite database
        options.UseSqlite(@"Data Source=test.db");
    }
   
   public DbSet<Books> AustenNovels {get; set;}
}
