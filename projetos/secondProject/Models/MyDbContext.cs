using secondProject.Models;
using Microsoft.EntityFrameworkCore;

namespace secondProject.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }

        public DbSet<Catalog> Catalog { get; set; }
        public DbSet<Books> Books { get; set; }
        public DbSet<GeneralBook> GeneralBook { get; set; }
        public DbSet<ReferenceBook> ReferenceBook { get; set; }
        public DbSet<Librarian> Librarian { get; set; }
        public DbSet<Member> Member { get; set; }
        public DbSet<FacultyMember> FacultyMember { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Alert> Alert { get; set; }

    }

}