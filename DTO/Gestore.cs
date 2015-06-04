using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PointrestServerSide.DTO
{
    public class Gestore
    {
        public string ID { get; set; }
        public string nome { get; set; }
        public string password { get; set; }
        public List<PuntoInteresse> puntiInteresseGestiti { get; set; }
        public Gestore(string ID, string nome, string password, List<PuntoInteresse> cPuntiInteresseGestiti)
        {
            this.ID = ID;
            this.nome = nome;
            this.password = password; // da criptare

            if (cPuntiInteresseGestiti != null)
            {
                this.puntiInteresseGestiti = cPuntiInteresseGestiti;
            }
        }
        
    }
}