using PointrestServerSide.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PointrestServerSide.Controllers
{
    public class GestoreController : ApiController
    {
        //// GET: api/Gestore
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET: api/Gestore/5
        [HttpGet]
        public Gestore Get(int id)
        {
            //return : [class Gestore,[class PuntoInteresse ]]
            //info: ritorna le info del gestore con id == {id}

            return new Gestore("1234", "Il nome del gestore", "la passowrd", null);
        }

        // POST: api/Gestore
        [HttpPost]
        public void Post(Gestore gestore)
        {

        }

        //// PUT: api/Gestore/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE: api/Gestore/5
        //public void Delete(int id)
        //{
        //}
    }
}
