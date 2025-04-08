
namespace FalconOps.API.Services.Simulator;

public interface IWaypointNavigator
{
    Waypoint GetNextWaypoint();
    UAVState UpdatePosition(UAVState currentState);

    bool IsMissionComplete(UAVState state);
}