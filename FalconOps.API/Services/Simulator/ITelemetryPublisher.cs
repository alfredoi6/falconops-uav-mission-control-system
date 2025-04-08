
namespace FalconOps.API.Services.Simulator;

public interface ITelemetryPublisher
{
    Task PublishAsync(UAVState state);
}