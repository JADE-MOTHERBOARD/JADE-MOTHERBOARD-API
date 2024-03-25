using Jade.Motherboard.Domain.Catalog;
using Microsoft.EntityFrameworkCore;

namespace Jade.Motherboard.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        { }

        public DbSet<Item> Items { get; set; }
    }
}