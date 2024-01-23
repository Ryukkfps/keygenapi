using Microsoft.EntityFrameworkCore;
using KeyGen.Models;

namespace KeyGen.Data
{
    public class KeyGeneratorDBContext : DbContext
    {
        
        public DbSet<University> Universities { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<ExamType> ExamTypes { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<AnswerKey> AnswerKeys { get; set; }
        public DbSet<Paper> Papers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserAuth> UserAuthentication { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Module> Modules { get; set; }

        public KeyGeneratorDBContext(DbContextOptions<KeyGeneratorDBContext> options) : base(options)
        {
            
        }
    }
}
