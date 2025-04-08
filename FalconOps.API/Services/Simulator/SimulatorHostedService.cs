namespace FalconOps.API.Services.Simulator;

/// <summary>
/// A background service that runs the UAV telemetry simulator periodically.
/// It orchestrates the simulation loop, publishing and logging data at regular intervals.
/// </summary>
public class SimulatorHostedService : BackgroundService
{
    private readonly TelemetrySimulator _simulator;
    private readonly ILogger<SimulatorHostedService> _logger;

    public SimulatorHostedService(
        TelemetrySimulator simulator,
        ILogger<SimulatorHostedService> logger)
    {
        _simulator = simulator;
        _logger = logger;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        _logger.LogInformation("Telemetry Simulator started.");
        await _simulator.RunSimulationAsync(stoppingToken);
        _logger.LogInformation("Telemetry Simulator stopped.");
    }
}