using System.ComponentModel.DataAnnotations;

namespace FalconOps.API.Services.Simulator;

/// <summary>
/// Represents a single telemetry log entry stored in the database.
/// Contains the state of the UAV at a specific point in time.
/// </summary>
public class TelemetryLog
{
    public int Id { get; set; }
    public DateTime Timestamp { get; set; }
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public double Altitude { get; set; }
    public double Battery { get; set; }
    public double SignalStrength { get; set; }
}