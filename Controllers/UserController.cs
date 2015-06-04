using PointrestServerSide.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PointrestServerSide.Controllers
{
    public class UserController : ApiController
    {
        //// GET: api/User
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET: api/User/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST: api/User
        [HttpGet]
        public HttpResponseMessage Post( User user )
        {
            //return : “201” succesfull, “403” denied, “500” internal server error
            HttpResponseMessage response = Request.CreateResponse( HttpStatusCode.OK, "ok" );
            response.Content = new StringContent( "hello", Encoding.Unicode );
            return response;
        }

        //POST: api/User/5
        [HttpPost]
        public void Post( int id, [FromBody]string idPuntoInteresse )
        {

        }

        //// PUT: api/User/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE: api/User/5
        //public void Delete(int id)
        //{
        //}
    }
}
