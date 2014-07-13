using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Monitoring.RunningTotals;
using Monitoring.RunningTotals.Defaults;

namespace Monitoring
{
	public class Program
	{
		static void Main(string[] args)
		{
			Metric metric1 = new Metric("metric1");
			metric1.AddRunningTotal("Average", new RunningTotalDefault_Average(10));
			metric1.AddRunningTotal("Max", new RunningTotalDefault_Max());
			metric1.AddRunningTotal("Min", new RunningTotalDefault_Min());

			for (decimal i = -24; i < 24; i++)
			{
				metric1.ApplyValue(i);
			}
				

			var values = metric1.GetCurrentValues();
			foreach (var items in values)
			{
				Console.WriteLine("{0}: {1}", items.Name, items.Value);
			}

			Console.WriteLine("Done.");
			Console.ReadLine();
		}
	}
}
