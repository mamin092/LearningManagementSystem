using System.Data.Entity;

namespace Model
{
    public class BusinessDbContext : DbContext
    {
        public BusinessDbContext() : base("DefaultBusinessConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
            
        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Teacher> Teachers { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Content> Contents { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<StudentContent> StudentContents { get; set; }
        

    }
}