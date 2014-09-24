using System;

namespace Monitoring.Metrics.RunningTotals.Defaults
{
	public class RunningTotalDefault_Min : IRunningTotalCalculation
	{
		public RunningTotalDefault_Min()
		{
			this.min = decimal.MaxValue;
		}

		private decimal min;

		public decimal ApplyValue(ApplyFunctionCommand cmd)
		{
			if (cmd.NewValue < this.min)
			{
				this.min = cmd.NewValue;
			}
			return this.min;
		}
	}
}

