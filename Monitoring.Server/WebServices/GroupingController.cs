using System;
using System.Net;
using System.Web.Http;

using Monitoring.Metrics;
using Monitoring.Server;

namespace Monitoring.Server.WebServices
{
    [RoutePrefix("Grouping")]
    public class GroupingController : ApiController
    {
        public GroupingController()
        {
        }

        [HttpPut]
        public IHttpActionResult AddGrouping(AddGroupingCommand cmd)
        {
            MetricGrouping newGrouping = new MetricGrouping(cmd.GroupingName);
            MainClass.MainRouter.AddGrouping(newGrouping);
            return Ok();
        }
    }
}

