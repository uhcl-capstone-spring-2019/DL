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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private async void BtnGetCurrentLoc_Click(object sender, EventArgs e)
        {
            LocationDL locationDl = new LocationDL();
            Location currentLocationInFirebase = await locationDl.GetCurrentLocation();
            MessageBox.Show($"Latitude is: {currentLocationInFirebase.Latitude} and Longitude is: {currentLocationInFirebase.Longitude}");
        }

        private void BtnSetCurrentLoc_Click(object sender, EventArgs e)
        {
            SetCurrentLocationForm setForm = new SetCurrentLocationForm();
            setForm.ShowDialog();
        }

        private void BtnOpenProject_Click(object sender, EventArgs e)
        {
            OpenProjectForm openProjectForm = new OpenProjectForm();
            openProjectForm.ShowDialog();
        }
    }
}
