using Microsoft.EntityFrameworkCore;
using Task.Models;

namespace Task.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Slider> Sliders { get; set; }
        public object Services { get; internal set; }
    }
}
