using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monitoring
{
    public class Metric
    {
        public Metric()
        {
            this.RunningTotals = new List<RunningTotal>();
        }

        public List<RunningTotal> RunningTotals;
    }
}
