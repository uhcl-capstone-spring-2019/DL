using FireSharp.Response;
using SWEN5232.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWEN5232.DataLayer
{
    public class LocationDL : BaseDL
    {
        public Location Location
        {
            get => default(Location);
            set
            {
            }
        }

        public async Task<Location> GetCurrentLocation()
        {
            FirebaseResponse response = await _client.GetAsync("/CurrentLocation");
            Location location = response.ResultAs<Location>();
            return location;
        }

        public async Task SetCurrentLocation(Location locationDetails)
        {
            if (locationDetails == null)
                throw new ArgumentNullException();

            SetResponse response = await _client.SetAsync("/CurrentLocation", locationDetails);

        }

    }
}
