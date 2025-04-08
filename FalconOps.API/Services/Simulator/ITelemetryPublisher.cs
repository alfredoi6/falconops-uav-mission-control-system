namespace FalconOps.API.Services.Simulator;

/// <summary>
/// Defines the contract for publishing telemetry data.
/// Implementations of this interface are responsible for sending UAV state updates to subscribers.
/// </summary>
public interface ITelemetryPublisher
{
    Task PublishAsync(UAVState state);
}