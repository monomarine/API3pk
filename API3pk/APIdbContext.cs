using API3pk.Models;
using Microsoft.EntityFrameworkCore;

namespace API3pk
{
    public class APIdbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        public APIdbContext(DbContextOptions options)
            : base(options) { }
    }
}
