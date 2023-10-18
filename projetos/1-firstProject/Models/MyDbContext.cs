using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using Microsoft.EntityFrameworkCore;

namespace fixingFirstProject.Models
{
    public class MyDbContext :DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }

        public DbSet<Usuario> Usuario { get; set; }
    }
}