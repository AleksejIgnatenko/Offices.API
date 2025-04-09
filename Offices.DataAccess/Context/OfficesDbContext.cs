using Microsoft.EntityFrameworkCore;
using Offices.Core.Models;

namespace Offices.DataAccess.Context;

public class OfficesDbContext : DbContext
{
    public DbSet<OfficeEntity> Offices { get; set; }

    public OfficesDbContext(DbContextOptions<OfficesDbContext> options) : base(options) { }
}
