using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SWEN5232.DataLayer;
using SWEN5232.Models;

namespace ArFloodSimulator
{
    public partial class SetCurrentLocationForm : Form
    {
        public SetCurrentLocationForm()
        {
            InitializeComponent();
        }

        private async void BtnSetCurrentLoc_Click(object sender, EventArgs e)
        {
           var isValidData = ValidateSetLocationData();

            if (!isValidData)
                return;

            Location location = new Location
            {
                Latitude = latitudeTextBox.Text,
                Longitude = longitudeTextBox.Text,
                Altitude = altitudeTextBox.Text
            };

            await new LocationDL().SetCurrentLocation(location);

            MessageBox.Show("Location Set Successfully.");
        }

        public bool ValidateSetLocationData()
        {
            if (string.IsNullOrEmpty(latitudeTextBox.Text) || string.IsNullOrEmpty(longitudeTextBox.Text) || string.IsNullOrEmpty(altitudeTextBox.Text))
            {
                MessageBox.Show("Please Enter All Fields.");
                return false;
            }

            bool isValid = true;

            string latitude = latitudeTextBox.Text;
            string longitude = longitudeTextBox.Text;

            if (!float.TryParse(latitude, out float x))
            {
                MessageBox.Show("Invalid Number. Please enter valid Latitude.");
                isValid = false;
            }
            else if (!float.TryParse(longitude, out float y))
            {
                MessageBox.Show("Invalid Number. Please enter valid Longitude.");
                isValid = false;
            }

            return isValid;
        }
    }
}
