using Microsoft.AspNetCore.SignalR;

namespace FalconOps.API.Services.Simulator;

/// <summary>
/// Publishes telemetry data to connected clients using SignalR.
/// This implementation sends UAVState updates to the TelemetryHub.
/// </summary>
public class SignalRTelemetryPublisher : ITelemetryPublisher
{
    private readonly IHubContext<TelemetryHub> _hubContext;

    public SignalRTelemetryPublisher(IHubContext<TelemetryHub> hubContext)
    {
        _hubContext = hubContext;
    }

    public async Task PublishAsync(UAVState state)
    {
        await _hubContext.Clients.All.SendAsync("ReceiveTelemetry", state);
    }
}