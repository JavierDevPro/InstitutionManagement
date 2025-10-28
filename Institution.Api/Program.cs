
using Institution.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddOpenApi();


var connection = builder.Configuration.GetConnectionString("ConnectionDefault");
builder.Services.AddDbContext<AppDbContext>(
    options =>
        options.UseMySql(connection, MySqlServerVersion.AutoDetect(connection)));

builder.Services.AddOpenApi();

var app = builder.Build();

app.UseHttpsRedirection();

app.MapControllers();
app.Run();