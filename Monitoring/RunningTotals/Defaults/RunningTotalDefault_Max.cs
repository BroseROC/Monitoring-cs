using System;

namespace Monitoring.RunningTotals.Defaults
{
	public class RunningTotalDefault_Max : IRunningTotalCalculation
	{
		public RunningTotalDefault_Max()
		{
			this.max = decimal.MinValue;
		}

		private decimal max;

		public decimal ApplyValue(ApplyFunctionCommand cmd)
		{
			if (cmd.NewValue > this.max)
			{
				this.max = cmd.NewValue;
			}
			return this.max;
		}
	}
}

