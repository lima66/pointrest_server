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
        public string sottocategoria { get; set; }
        public string descrizione { get; set; }
        public double latitudine { get; set; }
        public double longitudine { get; set; }
        public string tipo { get; set; }
        public List<Image> images { get; set; }

        public PuntoInteresse(string ID, string IDGestore, string nome, string categoria, string sottocategoria, 
            string descrizione, double latitudine, double longitudine, string tipo, List<Image> images)
        {
            this.ID = ID;
            this.IDGestore = IDGestore;
            this.nome = nome;
            this.categoria = categoria;

            if (sottocategoria != null)
            {
                this.sottocategoria = sottocategoria;
            }
            
            this.descrizione = descrizione;
            this.latitudine = latitudine;
            this.longitudine = longitudine;
            this.tipo = tipo;

            if (images != null)
            {
                this.images = images;
            }
        }
        

    }
}