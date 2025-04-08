namespace FalconOps.API.Services.Simulator;

public class WaypointNavigator : IWaypointNavigator
{
    private readonly List<Waypoint> _waypoints;

    public WaypointNavigator(List<Waypoint> waypoints)
    {
        _waypoints = waypoints;
    }

    public Waypoint GetNextWaypoint()
    {
        return _waypoints.Count > 0 ? _waypoints[0] : null;
    }

    public UAVState UpdatePosition(UAVState currentState)
    {
        if (currentState.CurrentWaypointIndex >= _waypoints.Count)
            return currentState;

        var target = _waypoints[currentState.CurrentWaypointIndex];

        currentState.Latitude = target.Latitude;
        currentState.Longitude = target.Longitude;
        currentState.Altitude = target.Altitude;
        currentState.Battery -= 1.0;
        currentState.SignalStrength -= 0.5;

        currentState.CurrentWaypointIndex++;

        return currentState;
    }

    public bool IsMissionComplete(UAVState state)
    {
        return state.CurrentWaypointIndex >= _waypoints.Count;
    }
}