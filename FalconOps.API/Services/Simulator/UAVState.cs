
namespace FalconOps.API.Services.Simulator;

public class UAVState
{
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public double Altitude { get; set; }
    public double Battery { get; set; } = 100.0;
    public double SignalStrength { get; set; } = 100.0;
    public int CurrentWaypointIndex { get; set; } = 0;
}