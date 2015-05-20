using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PointrestServerSide.Controllers
{
    public class PiController : ApiController
    {
        //// GET: api/Pi
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET: api/Pi/5
        [HttpGet]
        public string Get(CurrentUserData currentDataUser)
        {

            //return: [class PuntoInteresse]
            //info: ritorna un array di punti d’interesse in base al currentDataUser

            return "value";
        }
        [HttpGet]
        public string Get(int id)
        {

            //return: [class PuntoInteresse]
            //info: ritorna un array di punti d’interesse in base al currentDataUser

            return "value";
        }

        // POST: api/Pi
        [HttpPost]
        public void Post(int gestoreID , PuntoInteresse pi)
        {
            //return : “201” if succesfull, “403” denied, “500” internal server error
            //info: registra un nuovo punto di interesse per il gestore con id == {gestoreID}

        }

        //// PUT: api/Pi/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE: api/Pi/5
        //public void Delete(int id)
        //{
        //}
    }
}
