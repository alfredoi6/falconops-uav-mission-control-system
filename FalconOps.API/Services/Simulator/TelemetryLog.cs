namespace FalconOps.API.Services.Simulator;

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