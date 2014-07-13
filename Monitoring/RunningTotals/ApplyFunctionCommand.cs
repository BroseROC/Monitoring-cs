using System;

namespace Monitoring.RunningTotals
{
    public class ApplyFunctionCommand
    {
        public decimal? CurrentValue;
        public int MetricCount;
        public decimal NewValue;
        public DateTime RecievedDT;
    }
}

