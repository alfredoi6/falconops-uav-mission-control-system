using Microsoft.EntityFrameworkCore;

namespace FalconOps.API.Services.Simulator;

public class TelemetryDbContext : DbContext
{
    public TelemetryDbContext(DbContextOptions<TelemetryDbContext> options) : base(options) { }

    public DbSet<TelemetryLog> TelemetryLogs { get; set; }
}