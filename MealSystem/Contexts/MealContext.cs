using MealSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace MealSystem.Contexts
{
    public class MealContext : DbContext
    {
        public MealContext(DbContextOptions<MealContext> options) : base(options)
        { 
        }

        public DbSet<Ticket> Tickets { get; set; }
    }
}
