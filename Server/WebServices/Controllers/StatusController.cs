using System;
using System.Net;
using System.Web.Http;

using Server.WebServices.Models;

namespace Server.WebServices.Controllers
{
    public class StatusController : ApiController
    {
        public StatusController()
        {
        }


        [ActionName("")]
        [HttpGet]
        public IHttpActionResult Get(){
            BasicStatusModel model = new BasicStatusModel();
            model.Version = "0";
            model.ServerDT = DateTime.Now;
            return Ok(model);
        }
    }
}

