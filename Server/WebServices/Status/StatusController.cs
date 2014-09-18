using System;
using System.Net;
using System.Web.Http;

namespace Server.WebServices.Status
{
    [RoutePrefix("status")]
    public class StatusController : ApiController
    {
        public StatusController()
        {
        }


        [HttpGet]
        public IHttpActionResult Get()
        {
            BasicStatusModel model = new BasicStatusModel();
            model.Version = "0";
            model.ServerDT = DateTime.Now;
            return Ok(model);
        }
    }
}

