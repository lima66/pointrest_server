using PointrestServerSide.Models;
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
        public List<PuntoInteresse> Get(CurrentUserData currentDataUser)
        {

            //return: [class PuntoInteresse]
            //info: ritorna un array di punti d’interesse in base al currentDataUser

            List<PuntoInteresse> puntiInteresse = new List<PuntoInteresse>();


            //(string ID, string IDGestore, string nome, string categoria, string sottocategoria, 
            //string descrizione, double latitudine, double longitudine, string tipo, List<Image> images
            puntiInteresse.Add(new PuntoInteresse("1234", "ID Gestore", "Il nome", "La categoria", "la sottocategoria", 
                                                    "la descrizione", 123.5, 123.5, "Il tipo", null));
            puntiInteresse.Add(new PuntoInteresse("5678", "ID Gestore 2", "Il nome 2", "La categoria 2", "la sottocategoria 2", 
                                                    "la descrizione 2", 123.5, 123.5, "Il tipo 2", null));

            return puntiInteresse;
        }
        [HttpGet]
        public PuntoInteresse Get(int id)
        {

            //return: [class PuntoInteresse]
            //info: ritorna il punto di interesse con id == id

            return new PuntoInteresse("5678", "ID Gestore 2", "Il nome 2", "La categoria 2", "la sottocategoria 2",
                                                    "la descrizione 2", 123.5, 123.5, "Il tipo 2", null);
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
