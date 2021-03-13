using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demoNetCore.Models
{
    public class ProjectManagementContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=LAB-B06\\SQL2017;Initial Catalog=PROJECTMANAGEMENT;User ID=sa;Password=123456"); //connectionString
        }

        public DbSet<employee> employees { get; set; }

    }
}
