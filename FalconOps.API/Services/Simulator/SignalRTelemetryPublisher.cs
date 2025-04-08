using Microsoft.AspNetCore.SignalR;

namespace FalconOps.API.Services.Simulator;

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