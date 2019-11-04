using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace HMS_WebAPI.Controllers
{
    public class AdminApiController : ApiController
    {
        HMSEntities hms = new HMSEntities();
        
        public IEnumerable<Customer> Get()
        {
            return hms.Customers.ToList();
        }

    }
}
