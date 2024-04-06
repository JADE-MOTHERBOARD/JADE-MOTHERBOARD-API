using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Jade.Motherboard.Data;

public class StoreContextFactory :IDesignTimeDbContextFactory<StoreContext> {
    public StoreContext CreateDbContext(string[] args) {
        var optionsBuilder = new DbContextOptionsBuilder<StoreContext>();

        optionsBuilder.UseSqlite("data Source=../Registrar.sqlite");
        return new StoreContext(optionsBuilder.Options);
    }
}