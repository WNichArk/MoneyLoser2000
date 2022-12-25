using MoneyLoser2000.Models.Enums;
using MoneyLoser2000.Services.Alpaca;

namespace MoneyLoser2000
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly IConfiguration _configuration;

        public Worker(ILogger<Worker> logger, IConfiguration config)
        {
            _logger = logger;
            _configuration = config;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                await Task.Delay(1000, stoppingToken);
                await RunAlpacaMeanReversions();
            }
        }

        protected Task RunAlpacaMeanReversions()
        {
            var enviro = AccountEnvironment.Paper;
            var actions = new List<AlpacaMeanReversionService>();
            var scale = 200m;
            var svcList = new List<string>
                {
                    "amd",
                    "aapl",
                    "F",
                    "TWTR",
                    "SPY"
                };
            return Task.WhenAll(svcList.Select(async a =>
            {
                var svc = new AlpacaMeanReversionService(a, scale, enviro, _configuration);
                await svc.Run();
            }));
        }
    }
}
