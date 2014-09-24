using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Monitoring.Metrics.RunningTotals;

namespace Monitoring.Metrics
{
	public class Metric
	{
		private Metric()
		{
			this.RunningTotals = new List<RunningTotal>();
		}

		public Metric(String name)
			: this()
		{
			this.Name = name;
		}

		public String Name { get; set; }

		public List<RunningTotal> RunningTotals;

		public RunningTotal AddRunningTotal(String name, IRunningTotalCalculation calc)
		{
			RunningTotal t = new RunningTotal(name, calc);
			this.AddRunningTotal(t);
			return t;
		}

		public void AddRunningTotal(RunningTotal t)
		{
			this.RunningTotals.Add(t);
		}

		public IEnumerable<RunningTotalCurrentValue> GetCurrentValues()
		{
			List<RunningTotalCurrentValue> values = new List<RunningTotalCurrentValue>();
			foreach (var item in this.RunningTotals)
			{
				if (item.HasValue)
				{
					values.Add(new RunningTotalCurrentValue
						{ 
							Name = item.Name,
							Value = item.CurrentValue
						});
				}
			}
			return values;
		}

		public void ApplyValue(decimal value)
		{
			foreach (RunningTotal total in this.RunningTotals)
			{
				total.ApplyValue(value);
			}
		}
	}
}
