using DevOps.Models;
using Microsoft.EntityFrameworkCore;

namespace DevOps.Data;

public class ApplicationDbContext: DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
    {
    }

    public DbSet<Timestamp> Timestamps { get; set; }
}

