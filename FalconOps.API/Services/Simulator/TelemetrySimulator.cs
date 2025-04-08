namespace FalconOps.API.Services.Simulator;

public class TelemetrySimulator
{
    private readonly IWaypointNavigator _navigator;
    private readonly ITelemetryPublisher _publisher;
    private readonly TelemetryLogger _logger;
    private UAVState _state;

    public TelemetrySimulator(
        IWaypointNavigator navigator,
        ITelemetryPublisher publisher,
        TelemetryLogger logger)
    {
        _navigator = navigator;
        _publisher = publisher;
        _logger = logger;
        _state = new UAVState();
    }

    public async Task RunSimulationAsync(CancellationToken cancellationToken)
    {
        while (!cancellationToken.IsCancellationRequested && !_navigator.IsMissionComplete(_state))
        {
            _state = _navigator.UpdatePosition(_state);
            await _publisher.PublishAsync(_state);
            await _logger.LogTelemetryAsync(_state);
            await Task.Delay(1000, cancellationToken);
        }
    }
}