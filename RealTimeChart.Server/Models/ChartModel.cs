using System.Collections.Generic;

namespace RealTimeChart.Server.Models
{
    public class ChartModel
    {
        public string BackgroundColor { get; set; }
        public string Label { get; set; }
        public List<int> Data { get; set; }

        public ChartModel()
        {
            Data = new List<int>();
        }
    }
}