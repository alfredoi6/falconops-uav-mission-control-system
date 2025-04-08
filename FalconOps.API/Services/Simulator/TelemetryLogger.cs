namespace FalconOps.API.Services.Simulator;

/// <summary>
/// Service responsible for logging UAV telemetry data to persistent storage.
/// It uses the TelemetryDbContext to save TelemetryLog records.
/// </summary>
public class TelemetryLogger
{
    private readonly TelemetryDbContext _context;

    public TelemetryLogger(TelemetryDbContext context)
    {
        _context = context;
    }

    public async Task LogTelemetryAsync(UAVState state)
    {
        var log = new TelemetryLog
        {
            Timestamp = DateTime.UtcNow,
            Latitude = state.Latitude,
            Longitude = state.Longitude,
            Altitude = state.Altitude,
            Battery = state.Battery,
            SignalStrength = state.SignalStrength
        };

        _context.TelemetryLogs.Add(log);
        await _context.SaveChangesAsync();
    }
}
