using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monitoring.RunningTotals
{
	public class RunningTotal
	{
		public String Name;

		public decimal CurrentValue { get; private set; }

		public int MetricCount { get; private set; }

		public bool HasValue { get; private set; }

		private IRunningTotalCalculation calculator;

		private RunningTotal()
		{
			this.HasValue = false;
		}

		public RunningTotal(String name, IRunningTotalCalculation calc)
			: this()
		{
			this.Name = name;
			this.calculator = calc;
		}

		public RunningTotal(String name, IRunningTotalCalculation calc, decimal initialValue)
			: this(name, calc)
		{
			this.ApplyValue(initialValue);
		}

		public decimal ApplyValue(decimal value)
		{
			this.MetricCount++;
			decimal? currentValue = this.HasValue ? this.CurrentValue : (decimal?)null;
			this.CurrentValue = this.calculator.ApplyValue(new ApplyFunctionCommand
				{
					MetricCount = this.MetricCount,
					CurrentValue = currentValue,
					NewValue = value
				});
			this.HasValue = true;
			return this.CurrentValue;
		}
	}
}
