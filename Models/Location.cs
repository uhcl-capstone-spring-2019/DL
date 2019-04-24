using System;

namespace SWEN5232.Models
{
    [Serializable]
    public class Location
    {
        public string Address { get; set; }

        public string Altitude { get; set; }

        public string Longitude { get; set; }

        public string Latitude { get; set; }
    }
}
