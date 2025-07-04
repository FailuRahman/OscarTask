using Microsoft.EntityFrameworkCore;
using OscarTask.Models;
using System.Collections.Generic;

namespace OscarTask.DBContext
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
