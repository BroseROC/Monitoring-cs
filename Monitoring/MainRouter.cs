using System;
using System.Collections.Generic;

using Monitoring.Metrics;

namespace Monitoring
{
    public class MainRouter
    {
        public MainRouter()
        {
            this.groupings = new Dictionary<string, MetricGrouping>(StringComparer.OrdinalIgnoreCase);
        }

        private Dictionary<String, MetricGrouping> groupings;

        public void AddGrouping(MetricGrouping g)
        {
            this.groupings.Add(g.GroupingName, g);
        }

        public void RemoveGrouping(String groupingName)
        {
            this.groupings.Remove(groupingName);
        }

        public MetricGrouping GetGrouping(String name)
        {
            return this.groupings[name];
        }
    }
}