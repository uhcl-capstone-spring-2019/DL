using System;
using UnityEngine;

namespace SWEN5232.Models
{
    [Serializable]
    public class Building
    {

        [SerializeField]
        private int height;

        [SerializeField]
        private int length;

        [SerializeField]
        private int width;

        [SerializeField]
        private string name;

        [SerializeField]
        private string shape;

        [SerializeField]
        private string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public string Shape
        {
            get { return shape; }
            set { shape = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        public int Length
        {
            get { return length; }
            set { length = value; }
        }

    }
}
