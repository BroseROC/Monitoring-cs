using System;

namespace Monitoring.Metrics.RunningTotals
{
    public class ApplyFunctionCommand
    {
        public decimal? CurrentValue;
        public int MetricCount;
        public decimal NewValue;
        public DateTime RecievedDT;
    }
}

