using Again.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Again.Infrastructure.Data;

public class ApplicationDbContext:DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
    {
        
    }
    public DbSet<Waste> Wastes { get; set; }
    public DbSet<Profile> Profiles { get; set; }
}