using System;
using Microsoft.EntityFrameworkCore;

namespace api_angular_1.Models
{
    public class appDbContext:DbContext
    {
        public appDbContext(DbContextOptions<appDbContext> options)
            : base(options)
        {
        }

        public DbSet<customers> cust { get; set; }
    }
}
