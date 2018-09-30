using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace pollService.DataAccess
{
    public class PollContext : DbContext
    {
        public DbSet<Quiz> QuizSet { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=pollService.db");
        }
    }

}