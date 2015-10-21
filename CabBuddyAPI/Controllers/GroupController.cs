using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Security.Claims;
using System.Web.Http;
using Cabbuddy.Models;
using CabBuddyAPI.Filter;

namespace CabBuddyAPI.Controllers
{
    //[HMACAuthentication]
    [RoutePrefix("api/Group")]
    public class GroupController : ApiController
    {
        readonly CabBuddy.Business.GroupController _groupController = new CabBuddy.Business.GroupController();
  
        [Route("")]
        public IHttpActionResult Get()
        {
            var claimPrincipal = Request.GetRequestContext().Principal as ClaimsPrincipal;

            var name = ClaimsPrincipal.Current.Identity.Name;

            return Ok(Group.CreateGroup());
        }

        [Route("")]
        public IHttpActionResult Post(Group group)
        {
            _groupController.Save(group);
            return Ok(group);
        }        
    }
}
