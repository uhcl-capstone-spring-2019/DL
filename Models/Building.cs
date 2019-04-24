using System;

namespace SWEN5232.Models
{
    [Serializable]
    public class Building
    {
        public string Type { get; set; }

        public string Shape { get; set; }

        public string Name { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public int Length { get; set; }
    }
}
