using GroceryStoreWebApp.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using GroceryStoreWebApp.Models;

namespace GroceryStoreWebApp.Data;

public class GroceryStoreWebAppContext : IdentityDbContext<GroceryStoreWebAppUser>
{
    public GroceryStoreWebAppContext(DbContextOptions<GroceryStoreWebAppContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }

public DbSet<GroceryStoreWebApp.Models.Product> Product { get; set; } = default!;
    public DbSet<Employee> Employee { get; set; }
}
