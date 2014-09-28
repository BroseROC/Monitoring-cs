using System;
using System.Collections.Generic;

namespace Monitoring.Metrics
{
    public class MetricGrouping
    {
        private MetricGrouping()
        {
            this.metrics = new Dictionary<string, Metric>(StringComparer.OrdinalIgnoreCase);
        }

        public MetricGrouping(String groupingName)
            : this()
        {
            this.GroupingName = groupingName;
        }

        private Dictionary<String, Metric> metrics;
        public readonly String GroupingName;

        public void Update(String metricName, decimal metricValue)
        {
            if (this.metrics.ContainsKey(metricName))
            {
                this.metrics[metricName].ApplyValue(metricValue);
            }
            else
            {
                throw new Exception("Metric not found " + metricName);
            }
        }
    }
}