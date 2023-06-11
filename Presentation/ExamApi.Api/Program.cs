using ExamApi.Application;
using ExamApi.Application.Validator.Exams;
using ExamApi.Infrastructure.Filters;
using ExamApi.Persistence;
using FluentValidation.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddPersistenceServices();
builder.Services.AddApplicationServices();
builder.Services.AddCors(options => options.AddDefaultPolicy(policy =>
      //policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod()
      policy.WithOrigins("https://localhost:4200", "http://localhost:4200", "https://localhost:7068", "http://localhost:7068").AllowAnyHeader().AllowAnyMethod()
    ));
builder.Services.AddControllers(options => options.Filters.Add<ValidationFilter>())
    .AddFluentValidation(configuration => configuration.RegisterValidatorsFromAssemblyContaining<CreateExamValidator>())
    .ConfigureApiBehaviorOptions(options => options.SuppressModelStateInvalidFilter = true);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();

app.UseAuthorization();
app.UseCors();
app.MapControllers();

app.Run();
