using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PointrestServerSide.Models
{
    public class Gestore
    {
        public string ID { get; set; }
        public string nome { get; set; }
        public string password { get; set; }
        public List<PuntoInteresse> puntiInteresseGestiti { get; set; }
    }
}