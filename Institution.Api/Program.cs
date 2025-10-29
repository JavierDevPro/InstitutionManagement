
using Institution.Application.Interfaces;
using Institution.Application.Services;
using Institution.Domain.Entities;
using Institution.Domain.Interfaces;
using Institution.Infrastructure.Data;
using Institution.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddOpenApi();

// Repositories
builder.Services.AddScoped<IRepository<Student>, StudentRepository>();

// Services
builder.Services.AddScoped<IStudentService, StudentService>();

var connection = builder.Configuration.GetConnectionString("ConnectionDefault");
builder.Services.AddDbContext<AppDbContext>(
    options =>
        options.UseMySql(connection, MySqlServerVersion.AutoDetect(connection)));

builder.Services.AddOpenApi();
builder.Services.AddControllers();

var app = builder.Build();

app.UseHttpsRedirection();

app.MapControllers();
app.Run();