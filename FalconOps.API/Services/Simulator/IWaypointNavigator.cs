using FalconOps.DTOs.Map;

/// <summary>
/// Defines the contract for navigating a UAV between waypoints.
/// Implementations calculate the next state of the UAV based on its current state and the target waypoint.
/// </summary>
public interface IWaypointNavigator
{
    Waypoint GetNextWaypoint();
    UAVState UpdatePosition(UAVState currentState);

    bool IsMissionComplete(UAVState state);
}