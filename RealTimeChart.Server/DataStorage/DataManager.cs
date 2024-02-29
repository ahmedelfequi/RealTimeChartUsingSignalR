using RealTimeChart.Server.Models;
using System;
using System.Collections.Generic;

namespace RealTimeChart.Server.DataStorage
{
    public class DataManager
    {
        public static List<ChartModel> GetData()
        {
            var r = new Random();
            return new List<ChartModel>
            {
                new ChartModel{ Data = new List<int>{ r.Next(1, 40) }, Label = "Data 1", BackgroundColor = "#C51D34" },
                new ChartModel{ Data = new List<int>{ r.Next(1, 40) }, Label = "Data 2", BackgroundColor = "#2F4538" },
                new ChartModel{ Data = new List<int>{ r.Next(1, 40) }, Label = "Data 3", BackgroundColor = "#4C9141" },
                new ChartModel{ Data = new List<int>{ r.Next(1, 40) }, Label = "Data 4", BackgroundColor = "#CDA434" },
            };
        }
    }
}
