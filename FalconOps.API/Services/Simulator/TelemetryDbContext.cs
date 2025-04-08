using Microsoft.EntityFrameworkCore;

namespace FalconOps.API.Services.Simulator;

/// <summary>
/// Entity Framework Core DbContext for storing telemetry logs.
/// Configures the database connection and the TelemetryLog entity set.
/// </summary>
public class TelemetryDbContext : DbContext
{
    public TelemetryDbContext(DbContextOptions<TelemetryDbContext> options) : base(options) { }

    public DbSet<TelemetryLog> TelemetryLogs { get; set; }
}