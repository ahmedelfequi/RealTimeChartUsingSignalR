using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using RealTimeChart.Server.DataStorage;
using RealTimeChart.Server.SignalRHubs;
using RealTimeChart.Server.TimerFeatures;

namespace RealTimeChart.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChartController : ControllerBase
    {
        private readonly IHubContext<ChartHub> _hub;
        private readonly TimerManager _timerManager;
        public ChartController(IHubContext<ChartHub> hub, TimerManager timerManager)
        {
            _hub = hub;
            _timerManager = timerManager;
        }

        [HttpGet]
        public IActionResult GetChartData()
        {
            if (!_timerManager.IsTimerStarted)
                _timerManager.PrepareTimer(() => _hub.Clients.All.SendAsync("TransferChartData", DataManager.GetData()));

            return Ok(new { Message = "The request is completed successfully." });
        }
    }
}