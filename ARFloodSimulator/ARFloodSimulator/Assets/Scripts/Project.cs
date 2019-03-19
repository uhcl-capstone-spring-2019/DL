using System;
using UnityEngine;

namespace SWEN5232.Models
{
    [Serializable]
    public class Project
    {
        public string ProjectID { get; set; }

        [SerializeField]
        private string projectName;
        [SerializeField]
        private int floodLevel;
        [SerializeField]
        private Building building;
        [SerializeField]
        private Location location;

        public Location Location
        {
            get { return location; }
            set { location = value; }
        }
        public Building Building
        {
            get { return building; }
            set { building = value; }
        }
        public string ProjectName
        {
            get { return projectName; }
            set { projectName = value; }
        }
        public int FloodLevel
        {
            get { return floodLevel; }
            set { floodLevel = value; }
        }
    }
}
