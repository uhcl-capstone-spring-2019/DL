using System;
using System.Net;
using UnityEngine;
using SWEN5232.Models;
using SWEN5232.DataLayer;

/// <summary>
/// Dummy script to test the data layer.
/// </summary>
public class TestScript : MonoBehaviour
{
    /// <summary>
    /// Test Method to set the current location.
    /// </summary>
    public async void SetCurrentLocation()
    {
        var locationDL = new LocationDL();
        Location location = new Location("31.968599", "-99.901810", "5.17z", "151 East 77th Street, Manhattan, NY"); // dummy data
        bool isSaved = await locationDL.Set_currentlocation(location);

        if (isSaved)
            Debug.Log("Current location set successfully");
        else
            Debug.Log("Unable to save location.");
    }

    /// <summary>
    /// Test method to get current location.
    /// </summary>
    public async void GetCurrentLocation()
    {
        var locationDL = new LocationDL();
        Location currentLocation = await locationDL.Get_currentlocation();

        if (currentLocation != null)
        {
            Debug.Log("Current location is: ");
            Debug.Log($"Latitude : {currentLocation.Latitude}");
            Debug.Log($"Longitude : {currentLocation.Longitude}");
            Debug.Log($"Altitude : {currentLocation.Altitude}");
            Debug.Log($"Address : {currentLocation.Address}");
        }
        else
            Debug.Log("Unable to fetch current locations.");

    }

    /// <summary>
    /// Test method to get current location with address.
    /// </summary>
    public async void Get_Location()
    {
        SWEN5232.DataLayer.LocationDL locationDL = new SWEN5232.DataLayer.LocationDL();
        Location fetchedLocation = await locationDL.Get_Location("The Palm Dubai");
        if (fetchedLocation != null)
        {
            Debug.Log("Location for address found");
        }
    }

    /// <summary>
    /// Test method to save project data in database.
    /// </summary>
    public async void Save_Project()
    {
        SWEN5232.DataLayer.ProjectDL projectDL = new SWEN5232.DataLayer.ProjectDL();

        Project dummyProject = new Project
        {
            ProjectName = "My First Project",
            Building = new Building
            {
                Height = 435,
                Length = 487,
                Width = 444,
                Shape = "Rectangle",
                Name = "Trump Tower",
                Type = "Office Building"
            },
            Location = new Location
            {
                Address = "725 5th Ave, New York, NY 10022, USA",
                Latitude = "40.7625",
                Longitude = "-73.9738",
                Altitude = "78z"
            },
            FloodLevel = 7
        };

        bool isSaved = await projectDL.Save_Project(dummyProject);

        var msg = isSaved ? "Project data saved in database" : "Project Not Saved";

        Debug.Log(msg);

    }

    /// <summary>
    /// Test method to delete a project.
    /// </summary>
    public async void Delete_Project()
    {
        SWEN5232.DataLayer.ProjectDL projectDL = new SWEN5232.DataLayer.ProjectDL();

        Project dummyProject = new Project
        {
            ProjectID = "103f9568-24b6-4ba4-bff5-ddf295555863"
        };

        bool isDeleted = await projectDL.Delete_Project(dummyProject);

        var msg = isDeleted ? "Project deleted from database" : "Project Not Deleted.";

        Debug.Log(msg);

    }

    /// <summary>
    /// Test method to open a project from database.
    /// </summary>
    public async void Open_Project()
    {
        SWEN5232.DataLayer.ProjectDL projectDL = new SWEN5232.DataLayer.ProjectDL();

        Project project = await projectDL.Open_Project("818378e6-7557-477d-ae3c-70a11efaae44");

        if (project != null)
        {
            Debug.Log("Project " + project.ProjectName + " details are fetched successfully");
        }
    }

    /// <summary>
    ///  To set the list of dummy locations in firebase.
    /// </summary>
    public void setdummylocation()
    {
        SWEN5232.DataLayer.LocationDL locationDL = new SWEN5232.DataLayer.LocationDL();
        locationDL.SetDummyLocations();
    }
}
