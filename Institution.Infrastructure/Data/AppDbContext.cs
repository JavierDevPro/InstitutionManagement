using Institution.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Institution.Infrastructure.Data;

public class AppDbContext : DbContext
{

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}

    public DbSet<Student> Students { get; set; }
    public DbSet<Professor> Professors { get; set; }
    public DbSet<CourseStatus> CourseStatuses { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<Inscription> Inscriptions { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // primary keys
        modelBuilder.Entity<Student>().HasKey(s => s.Id);
        modelBuilder.Entity<Professor>().HasKey(p => p.Id);
        modelBuilder.Entity<CourseStatus>().HasKey(s => s.Id);
        modelBuilder.Entity<Course>().HasKey(c => c.Id);
        modelBuilder.Entity<Inscription>().HasKey(i => i.Id);
        
        //Relationships
        modelBuilder.Entity<Student>()
            .HasMany(s => s.inscriptions)
            .WithOne(i => i.Student)
            .HasForeignKey(i => i.StudentId);

        modelBuilder.Entity<Professor>()
            .HasMany(p => p.Courses)
            .WithOne(c => c.Professor)
            .HasForeignKey(c => c.ProfessorId);

        modelBuilder.Entity<Course>()
            .HasMany(c => c.inscriptions)
            .WithOne(i => i.Course)
            .HasForeignKey(i => i.CourseId);

        modelBuilder.Entity<CourseStatus>()
            .HasMany(c => c.Courses)
            .WithOne(c => c.Status)
            .HasForeignKey(c => c.StatusId);
    }
}