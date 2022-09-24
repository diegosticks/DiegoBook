using DiegoBookWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace DiegoBookWeb.Data
{
    public class ApplicationDbContext : DbContext 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
    }
}
