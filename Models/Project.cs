using System;
using SWEN5232.Models;

namespace SWEN5232.Models
{
    [Serializable]
    public class Project
    {
        public Location Location { get; set; }
        public Building Building { get; set; }
        public string ProjectName { get; set; }
        public int FloodLevel { get; set; }
    }
}
