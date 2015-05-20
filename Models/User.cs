using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PointrestServerSide.Models
{
    public class User
    {
        public string ID { get; set; }
        public string userName { get; set; }
        public string name { get; set; }
        public string surName { get; set; }
        public List<PuntoInteresse> preferiti { get; set; }
    }
}