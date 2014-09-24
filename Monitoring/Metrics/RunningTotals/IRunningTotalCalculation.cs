using System;

namespace Monitoring.Metrics.RunningTotals
{
    public interface IRunningTotalCalculation
    {
        decimal ApplyValue(ApplyFunctionCommand cmd);
    }
}

