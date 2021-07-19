using System;
using Microsoft.EntityFrameworkCore;

namespace Resume_Builder.Models
{
    public class ResumeContext : DbContext
    {
        public DbSet<ResumeModel> Resumes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite(@"Data Source=/Users/maksimsbogdanovs/Projects/Resume_Builder/Resume_Builder/DB/Resume_DB");
    }
}
