using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace pollService.DataAccess
{

    /// <summary>
    /// �������� ���� ������
    /// </summary>
    public class PollContext : DbContext
    {
        /// <summary>
        /// ��������� �����������
        /// </summary>
        public DbSet<Quiz> QuizSet { get; set; }

        /// <summary>
        /// ��������� ����������
        /// </summary>
        public DbSet<QuizResult> QuizResultSet {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=pollService.db");
        }

    }

}