using System;

namespace Monitoring.RunningTotals
{
    public interface IRunningTotalCalculation
    {
        decimal ApplyValue(ApplyFunctionCommand cmd);
    }
}

