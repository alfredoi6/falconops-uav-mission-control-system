namespace FalconOps.API.Services.Simulator;

/// <summary>
/// Represents a single waypoint in a mission plan.
/// Defines a target location (latitude, longitude, altitude) for the UAV.
/// </summary>
public class Waypoint
{
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public double Altitude { get; set; }
}