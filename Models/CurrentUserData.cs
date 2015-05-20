using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PointrestServerSide.Models
{
    public class CurrentUserData
    {
        public int deviceID { get; set; }
        public double latitudine { get; set; }
        public double longitudine { get; set; }
        public int radius { get; set; }
        public string tipoPIdaRicevere { get; set; }

        public CurrentUserData(int deviceID, double latitudine, double longitudine, int radius, string tipoPIdaRicevere)
        {
            this.deviceID = deviceID;
            this.latitudine = latitudine;
            this.longitudine = longitudine;
            this.radius = radius;
            this.tipoPIdaRicevere = tipoPIdaRicevere;
        }
    }
}