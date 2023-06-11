using ExamApi.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamApi.Persistence
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ExamAPIDbContext>
    {
        public ExamAPIDbContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<ExamAPIDbContext> dbContextOptionsBuilder = new();
            dbContextOptionsBuilder.UseSqlServer(Configuration.ConnectionString);
            return new(dbContextOptionsBuilder.Options);
        }
    }
}
