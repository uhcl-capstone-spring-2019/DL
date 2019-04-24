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
    public partial class OpenProjectForm : Form
    {
        private Dictionary<string, Project> projectList;

        public OpenProjectForm()
        {
            InitializeComponent();
        }

        private async void OpenProjectForm_Load(object sender, EventArgs e)
        {
            projectListCombo.Enabled = false;
            panelProjectData.Visible = false;
            BtnUpdate.Visible = false;
            BtnEditCncl.Enabled = false;
            BtnCancelSaveProject.Visible = false;
            BtnNewSaveProj.Enabled = false;
            BtnDeleteProj.Visible = false;
            await FillComboBox();
            BtnNewSaveProj.Enabled = true;
            BtnDeleteProj.Visible = true;
            DisableEditing();
            projectListCombo.Enabled = true;
            BtnCancelSaveProject.Visible = false; // cancel button of save project.
        }

        public async Task FillComboBox()
        {
            BtnEditCncl.Enabled = false;
            ProjectDL projectDL = new ProjectDL();
            projectList = await projectDL.GetAllProjects();

            List<Tuple<string, string>> projectIdNameList = new List<Tuple<string, string>>();
            foreach (var item in projectList)
            {
                projectIdNameList.Add(new Tuple<string, string>(item.Key, item.Value.ProjectName));
            }

            projectListCombo.ValueMember = "Item1";
            projectListCombo.DisplayMember = "Item2";
            projectListCombo.DataSource = projectIdNameList;
            BtnEditCncl.Enabled = true;
        }

        private void FillAndShowProjDtls()
        {
            var projectID = projectListCombo.SelectedValue as string;
            var projectDetails = projectList.First(P => P.Key == projectID).Value;

            textBoxProjectName.Text = projectDetails.ProjectName;
            textBoxFloodLevel.Text = projectDetails.FloodLevel + "";

            textBoxBuildingName.Text = projectDetails.Building.Name;
            textBoxBuildingShape.Text = projectDetails.Building.Shape;
            textBoxBuildingType.Text = projectDetails.Building.Type;
            textBoxHeight.Text = projectDetails.Building.Height + "";
            textBoxWidth.Text = projectDetails.Building.Width + "";
            textBoxLength.Text = projectDetails.Building.Length + "";

            textBoxProjLati.Text = projectDetails.Location.Latitude;
            textBoxProjLongi.Text = projectDetails.Location.Longitude;
            textBoxProjAlti.Text = projectDetails.Location.Altitude;
            textBoxProjAddress.Text = projectDetails.Location.Address;

            panelProjectData.Visible = true;
        }

        private void ProjectListCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillAndShowProjDtls();
        }

        private void BtnEditCncl_Click(object sender, EventArgs e)
        {
            if (BtnEditCncl.Text == "Edit")
            {
                BtnEditCncl.Text = "Cancel";
                BtnUpdate.Visible = true;
                projectListCombo.Enabled = false;
                EnableEditing();
                BtnNewSaveProj.Visible = false;
            }
            else if (BtnEditCncl.Text == "Cancel")
            {
                BtnEditCncl.Text = "Edit";
                BtnUpdate.Visible = false;
                projectListCombo.Enabled = true;
                DisableEditing();
                FillAndShowProjDtls();
                BtnNewSaveProj.Visible = true;
            }
        }

        private void DisableEditing()
        {
            textBoxProjectName.Enabled = false;
            textBoxFloodLevel.Enabled = false;

            textBoxBuildingName.Enabled = false;
            textBoxBuildingShape.Enabled = false;
            textBoxBuildingType.Enabled = false;
            textBoxHeight.Enabled = false;
            textBoxWidth.Enabled = false;
            textBoxLength.Enabled = false;

            textBoxProjLati.Enabled = false;
            textBoxProjLongi.Enabled = false;
            textBoxProjAlti.Enabled = false;
            textBoxProjAddress.Enabled = false;
        }

        private void EnableEditing()
        {
            textBoxProjectName.Enabled = true;
            textBoxFloodLevel.Enabled = true;

            textBoxBuildingName.Enabled = true;
            textBoxBuildingShape.Enabled = true;
            textBoxBuildingType.Enabled = true;
            textBoxHeight.Enabled = true;
            textBoxWidth.Enabled = true;
            textBoxLength.Enabled = true;

            textBoxProjLati.Enabled = true;
            textBoxProjLongi.Enabled = true;
            textBoxProjAlti.Enabled = true;
            textBoxProjAddress.Enabled = true;
        }

        private async void BtnUpdate_Click(object sender, EventArgs e)
        {
            var projectId = projectListCombo.SelectedValue as string;
            var projectData = ReadAllFields();
            bool isUpdated = false;

            if (IsValidProjectData(projectData))
            {
                ProjectDL projectDL = new ProjectDL();
                isUpdated = await projectDL.UpdateProject(projectId, projectData);
            }

            if (isUpdated)
            {

                Task task = FillComboBox();
                MessageBox.Show("Project Updated Successfully");
                await task;
                projectListCombo.Enabled = true;
                BtnEditCncl.Text = "Edit";
                BtnUpdate.Visible = false;
                BtnNewSaveProj.Visible = true;
                DisableEditing();
                projectListCombo.SelectedValue = projectId;
            }
        }

        private Project ReadAllFields()
        {
            Project project = new Project
            {
                ProjectName = textBoxProjectName.Text,
                FloodLevel = string.IsNullOrEmpty(textBoxFloodLevel.Text) ? int.MinValue : int.Parse(textBoxFloodLevel.Text),
                Building = new Building
                {
                    Name = textBoxBuildingName.Text,
                    Type = textBoxBuildingType.Text,
                    Shape = textBoxBuildingShape.Text,
                    Height = string.IsNullOrEmpty(textBoxHeight.Text) ? int.MinValue : int.Parse(textBoxHeight.Text),
                    Width = string.IsNullOrEmpty(textBoxHeight.Text) ? int.MinValue : int.Parse(textBoxHeight.Text),
                    Length = string.IsNullOrEmpty(textBoxLength.Text) ? int.MinValue : int.Parse(textBoxLength.Text)
                },
                Location = new Location
                {
                    Latitude = string.IsNullOrEmpty(textBoxProjLati.Text) ? "" : float.Parse(textBoxProjLati.Text) + "",
                    Longitude = string.IsNullOrEmpty(textBoxProjLongi.Text) ? "" : float.Parse(textBoxProjLongi.Text) + "",
                    Altitude = textBoxProjAlti.Text,
                    Address = textBoxProjAddress.Text
                }
            };

            return project;
        }

        private bool IsValidProjectData(Project projectDetails)
        {
            var isValid = true;

            StringBuilder validationMsg = new StringBuilder();
            if (string.IsNullOrEmpty(projectDetails.ProjectName))
            {
                validationMsg.Append("Project name cannot be empty.");
                isValid = false;
            }

            if (projectDetails.FloodLevel == int.MinValue)
            {
                validationMsg.Append(Environment.NewLine + "Flood level cannot be empty.");
                isValid = false;
            }

            if (string.IsNullOrEmpty(projectDetails.Building.Name))
            {
                validationMsg.Append(Environment.NewLine + "Building Name cannot be empty.");
                isValid = false;
            }

            if (string.IsNullOrEmpty(projectDetails.Building.Type))
            {
                validationMsg.Append(Environment.NewLine + "Building Type cannot be empty.");
                isValid = false;
            }

            if (string.IsNullOrEmpty(projectDetails.Building.Shape))
            {
                validationMsg.Append(Environment.NewLine + "Building Shape cannot be empty.");
                isValid = false;
            }

            if (projectDetails.Building.Height == int.MinValue)
            {
                validationMsg.Append(Environment.NewLine + "Building Height cannot be empty.");
                isValid = false;
            }

            if (projectDetails.Building.Width == int.MinValue)
            {
                validationMsg.Append(Environment.NewLine + "Building Width cannot be empty.");
                isValid = false;
            }

            if (projectDetails.Building.Length == int.MinValue)
            {
                validationMsg.Append(Environment.NewLine + "Building length cannot be empty.");
                isValid = false;
            }

            if (string.IsNullOrEmpty(projectDetails.Location.Latitude))
            {
                validationMsg.Append(Environment.NewLine + "Latitude cannot be empty.");
                isValid = false;
            }

            if (string.IsNullOrEmpty(projectDetails.Location.Longitude))
            {
                validationMsg.Append(Environment.NewLine + "Longitude cannot be empty.");
                isValid = false;
            }

            if (string.IsNullOrEmpty(projectDetails.Location.Altitude))
            {
                validationMsg.Append(Environment.NewLine + "Altitude cannot be empty.");
                isValid = false;
            }

            if (string.IsNullOrEmpty(projectDetails.Location.Address))
            {
                validationMsg.Append(Environment.NewLine + "Address cannot be empty.");
                isValid = false;
            }

            if (!isValid)
            {
                MessageBox.Show(validationMsg.ToString());
            }

            return isValid;
        }

        private void AllowNumberOnly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void AllowDecimalOnly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private async void BtnNewSaveProj_Click(object sender, EventArgs e)
        {
            if (BtnNewSaveProj.Text == "New Project")
            {
                HandleNewProjAction();
                BtnNewSaveProj.Text = "Save";
            }
            else if (BtnNewSaveProj.Text == "Save")
            {
                await HandleSaveProjAction();

            }

            
        }

        private async Task HandleSaveProjAction()
        {
            var newProjectDtls = ReadAllFields();
            bool isvalid = IsValidProjectData(newProjectDtls);

            if (isvalid)
            {
                ProjectDL projectDL = new ProjectDL();

                bool isSaved = await projectDL.CreateNewProject(newProjectDtls);
                if (isSaved)
                {
                    AfterSaveProject();
                }
            }
        }

        public void AfterSaveProject()
        {
            FillComboBox();
            MessageBox.Show("Project Created Successfully.");
            BtnCancelSaveProject.Visible = false;
            projectListCombo.Visible = true;
            projectListCombo.Enabled = false;
            BtnEditCncl.Visible = true;
            BtnUpdate.Visible = false;
            BtnNewSaveProj.Visible = true;
            BtnNewSaveProj.Text = "New Project";
            BtnDeleteProj.Visible = true;
            DisableEditing();
        }

        private void HandleNewProjAction()
        {
            BtnCancelSaveProject.Visible = true;
            projectListCombo.Visible = false;
            BtnDeleteProj.Visible = false;
            BlankAllFields();
            EnableEditing();
        }

        private void BlankAllFields()
        {
            textBoxProjectName.Text = null;
            textBoxFloodLevel.Text = null;

            textBoxBuildingName.Text = null;
            textBoxBuildingShape.Text = null;
            textBoxBuildingType.Text = null;
            textBoxHeight.Text = null;
            textBoxWidth.Text = null;
            textBoxLength.Text = null;

            textBoxProjLati.Text = null;
            textBoxProjLongi.Text = null;
            textBoxProjAlti.Text = null;
            textBoxProjAddress.Text = null;
        }

        private void BtnCancelSaveProject_Click(object sender, EventArgs e)
        {
            BtnNewSaveProj.Text = "New Project";
            BtnEditCncl.Visible = true;
            projectListCombo.Visible = true;
            BtnEditCncl.Text = "Edit";
            BtnCancelSaveProject.Visible = false;
            DisableEditing();
            FillAndShowProjDtls();
            BtnDeleteProj.Visible = true;
        }

        private async void BtnDeleteProj_Click(object sender, EventArgs e)
        {
            ProjectDL projDl = new ProjectDL();
            var projID = projectListCombo.SelectedValue as string;
            bool isDeleted = await projDl.DeleteProject(projID);
            if (isDeleted)
            {
                FillComboBox();
                MessageBox.Show("Project Deleted Successfully.", "Success");
            }
        }
    }
}
