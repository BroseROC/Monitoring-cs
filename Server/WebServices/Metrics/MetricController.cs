using System;
using System.Net;
using System.Web.Http;

namespace Server.WebServices.Metrics
{
    [RoutePrefix("metric")]
    public class MetricController
    {
        public MetricController()
        {
        }

        [HttpPost]
        public void AddMetric()
        {

        }
    }
}

