using ExamApi.Application.Repositories;
using ExamApi.Persistence.Contexts;
using ExamApi.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ExamApi.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<ExamAPIDbContext>(option =>
            option.UseSqlServer(Configuration.ConnectionString));
            services.AddScoped<IStudentReadRepository, StudentReadRepository>();
            services.AddScoped<IStudentWriteRepository, StudentWriteRepository>();
            services.AddScoped<IExamReadRepository, ExamReadRepository>();
            services.AddScoped<IExamWriteRepository, ExamWriteRepository>();
            services.AddScoped<ILessonReadRepository, LessonReadRepository>();
            services.AddScoped<ILessonWriteRepository, LessonWriteRepository>();
        }
    }
}
