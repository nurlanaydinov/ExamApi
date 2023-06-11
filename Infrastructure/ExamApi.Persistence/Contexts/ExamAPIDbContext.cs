using ExamApi.Domain.Entities;
using ExamApi.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;

namespace ExamApi.Persistence.Contexts
{
    public class ExamAPIDbContext : DbContext
    {
        public ExamAPIDbContext(DbContextOptions options) : base(options)
        { }

        public DbSet<Students> Students { get; set; }
        public DbSet<Lessons> Lessons { get; set; }
        public DbSet<Exams> Exams { get; set; }
       

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var datas = ChangeTracker
                .Entries<BaseEntity>();
            foreach (var data in datas)
            {
                _ = data.State switch
                {
                    EntityState.Added => data.Entity.CreatedDate = DateTime.Now,
                    EntityState.Modified => data.Entity.UpdatedDate = DateTime.Now,
                    _ => DateTime.Now
                };
            }
            return base.SaveChangesAsync(cancellationToken);
        }

    }
}
