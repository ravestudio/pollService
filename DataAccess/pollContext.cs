using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace pollService.DataAccess
{

    /// <summary>
    /// контекст базы данных
    /// </summary>
    public class PollContext : DbContext
    {
        /// <summary>
        /// хранилище вопросников
        /// </summary>
        public DbSet<Quiz> QuizSet { get; set; }

        /// <summary>
        /// хранилище статистики
        /// </summary>
        public DbSet<QuizResult> QuizResultSet {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=pollService.db");
        }

    }

}