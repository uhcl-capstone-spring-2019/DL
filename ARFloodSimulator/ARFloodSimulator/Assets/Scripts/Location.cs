using System;
using UnityEngine;

namespace SWEN5232.Models
{
    [Serializable]
    public class Location
    {
        public Location(string lat, string longi, string alti)
        {
            latitude = lat;
            longitude = longi;
            altitude = alti;
        }

        public Location(string lat, string longi, string alti, string address)
        {
            latitude = lat;
            longitude = longi;
            altitude = alti;
            this.address = address;
        }

        public Location() { }

        [SerializeField]
        private string latitude;
        [SerializeField]
        private string longitude;
        [SerializeField]
        private string altitude;
        [SerializeField]
        private string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string Altitude
        {
            get { return altitude; }
            set { altitude = value; }
        }

        public string Longitude
        {
            get { return longitude; }
            set { longitude = value; }
        }

        public string Latitude
        {
            get { return latitude; }
            set { latitude = value; }
        }

    }
}
