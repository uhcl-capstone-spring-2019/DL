using Firebase.Database;
using SWEN5232.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

namespace SWEN5232.DataLayer
{
    /// <summary>
    /// Class to save/fetch data related to location.
    /// </summary>
    public class LocationDL
    {

        /// <summary>
        /// Method to save the current location to firebase.
        /// </summary>
        /// <param name="locationData"></param>
        /// <returns></returns>
        public async Task<bool> Set_currentlocation(Location locationData)
        {
            var json = JsonUtility.ToJson(locationData);

            var isSaved = false;
            await FirebaseManager.dataRef.Child("CurrentLocation").SetRawJsonValueAsync(json).ContinueWith(T =>
            {
                if (T.IsCompleted && !T.IsFaulted)
                {
                    isSaved = true;
                }
            });

            return isSaved;
        }

        /// <summary>
        /// Method to get the current location from firebase which was set by Set_currentlocation method.
        /// </summary>
        /// <returns></returns>
        public async Task<Location> Get_currentlocation()
        {
            Location locationToFetch = null;

            try
            {
                DataSnapshot snapshot = await FirebaseManager.dataRef.Child("CurrentLocation").GetValueAsync();

                if (snapshot != null && snapshot.Value != null)
                {
                    locationToFetch = JsonUtility.FromJson<Location>(snapshot.GetRawJsonValue());
                }
            }
            catch (Exception)
            {
                locationToFetch = null;
                Debug.LogError("Unable to fetch location data. Check internet connection.");
            }

            return locationToFetch;
        }

        /// <summary>
        /// Dummy method to save list of pre defined locations in firebase.
        /// </summary>
        public void SetDummyLocations()
        {
            List<Location> locations = new List<Location>
            {
                new Location
                {
                    Address = "Rixos The Palm Dubai",
                    Latitude = "25.1212",
                    Longitude = "55.1535",
                    Altitude = "XX"
                },
                new Location
                {
                    Address = "Shangri-La Hotel",
                    Latitude = "25.2084",
                    Longitude = "55.2719",
                    Altitude = "XX"
                },
                new Location
                {
                    Address = "Grand Hyatt",
                    Latitude = "25.2285",
                    Longitude = "55.3273",
                    Altitude = "XX"
                },
                new Location
                {
                    Address = "151 East 77th Street, Manhattan, NY",
                    Latitude = "-73.9596265",
                    Longitude = "40.7736566",
                    Altitude = "XX"
                }
            };

            foreach (var item in locations)
            {
                var json = JsonUtility.ToJson(item);
                var uniqueID = Guid.NewGuid().ToString();
                FirebaseManager.dataRef.Child("LocationList").Child(uniqueID).SetRawJsonValueAsync(json);
            }
        }

        /// <summary>
        /// Method to fetch the location and coordinates with address string.
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        public async Task<Location> Get_Location(string address)
        {
            if (address == null)
            {
                throw new ArgumentNullException();
            }

            Location foundLocation = null;

            DataSnapshot snapshot = await FirebaseManager.dataRef.Child("LocationList").GetValueAsync();

            if (snapshot != null)
            {
                var dict = snapshot.Value as Dictionary<string, object>;

                foreach (var obj  in dict)
                {
                    var  internalDict = obj.Value as Dictionary<string, object>;
                    string addrss = internalDict["address"].ToString();
                    if (addrss.ToUpperInvariant().Contains(address.ToUpperInvariant()))
                    {
                        foundLocation = new Location
                        {
                            Address = internalDict["address"].ToString(),
                            Latitude = internalDict["latitude"].ToString(),
                            Longitude = internalDict["longitude"].ToString(),
                            Altitude = internalDict["altitude"].ToString()
                        };
                        break;
                    }
                    
                }
            }

            return foundLocation;
        }
    }
}
