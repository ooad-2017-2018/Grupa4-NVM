using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MikrokreditnaOrganizacijaNVM.Models
{
    public class Locations
    {
        public double latitude { get; set; }
        public double longitude { get; set; }

        public Locations(double latitude, double longitude)
        {
            this.latitude = latitude;
            this.longitude = longitude;
        }
    }
}