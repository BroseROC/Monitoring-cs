using System;
using System.Collections.Generic;

namespace Monitoring.Metrics.RunningTotals.Defaults
{
	public class RunningTotalDefault_Average : IRunningTotalCalculation
	{
		public RunningTotalDefault_Average(int take)
		{
			this.Take = take;
			this.valuesQueue = new Queue<decimal>(this.Take);
		}

		public int Take { get; private set; }

		public Queue<decimal> valuesQueue;

		public decimal ApplyValue(ApplyFunctionCommand cmd)
		{
			this.addValueToQueue(cmd.NewValue);
			return this.getCurrentAverage();
		}

		private void addValueToQueue(decimal value)
		{
			if (this.valuesQueue.Count == this.Take)
			{
				this.valuesQueue.Dequeue();
			}
			this.valuesQueue.Enqueue(value);
		}

		private decimal getCurrentAverage()
		{
			int count = this.valuesQueue.Count;
			decimal sum = this.getCurrentSum();

			decimal average = sum / count;
			return average;
		}

		private decimal getCurrentSum()
		{
			decimal r = 0;
			foreach (decimal value in valuesQueue)
			{
				r += value;
			}
			return r;
		}
	}
}

