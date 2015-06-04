using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PointrestServerSide.DTO
{
    public class User
    {
        public User(string ID, string userName, string name, string surname, List<PuntoInteresse> cPreferiti)
        {
            this.ID = ID;
            this.userName = userName;
            this.name = name;
            this.surName = surName;
            
            if(cPreferiti != null) {
                preferiti = cPreferiti;
            }
        }

        public string ID { get; set; }
        public string userName { get; set; }
        public string name { get; set; }
        public string surName { get; set; }
        public List<PuntoInteresse> preferiti { get; set; }

    }
}