using SOSResources.Models;
using Microsoft.EntityFrameworkCore;

namespace SOSResources.Data
{
    public class SOSContext : DbContext
{
    public SOSContext(DbContextOptions<SOSContext> options) : base(options)
    {
    }

    public DbSet<Textbook> Textbooks { get; set; }
    public DbSet<Resource> Resources { get; set; }
    public DbSet<Participant> Participants { get; set; }
    public DbSet<TextbookRequest> textbookRequests { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Textbook>().ToTable(nameof(Textbook));
        modelBuilder.Entity<Resource>().ToTable(nameof(Resource));
        modelBuilder.Entity<Participant>().ToTable(nameof(Participant));
        modelBuilder.Entity<TextbookRequest>().ToTable(nameof(Participant));
    }
    
    // public DbSet<Course> Courses { get; set; }
    // public DbSet<Enrollment> Enrollments { get; set; }
    // public DbSet<Student> Students { get; set; }
    // public DbSet<Department> Departments { get; set; }
    // public DbSet<Instructor> Instructors { get; set; }
    // public DbSet<OfficeAssignment> OfficeAssignments { get; set; }
    
    // protected override void OnModelCreating(ModelBuilder modelBuilder)
    // {
    //     modelBuilder.Entity<Course>().ToTable(nameof(Course))
    //         .HasMany(c => c.Instructors)
    //         .WithMany(i => i.Courses);
    //     modelBuilder.Entity<Student>().ToTable(nameof(Student));
    //     modelBuilder.Entity<Instructor>().ToTable(nameof(Instructor));
    //     modelBuilder.Entity<Department>()
    //         .Property(d => d.ConcurrencyToken)
    //         .IsConcurrencyToken();
    // }
}
    }