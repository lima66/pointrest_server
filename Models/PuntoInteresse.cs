using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace PointrestServerSide.Models
{
    public class PuntoInteresse
    {
        public string ID { get; set; }
        public string IDGestore { get; set; }
        public string nome { get; set; }
        public string categoria { get; set; }
        public string? sottocategoria { get; set; }
        public string descrizione { get; set; }
        public double latitudine { get; set; }
        public double longitudine { get; set; }
        public string tipo { get; set; }
        public List<Image> images { get; set; }

    }
}