// using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

public class VidhyalayaDbContext : DbContext
{
    public DbSet<Grade> Grades { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Guardian> GuardianDetails{ get; set; }
  
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=Vidhyalaya.db");
    }
   


}

