using SWEN5232.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWEN5232.DataLayer
{
    public class ProjectDL : BaseDL
    {

        public Project Project
        {
            get => default(Project);
            set
            {
            }
        }

        public Building Building
        {
            get => default(Building);
            set
            {
            }
        }

        public async Task<Dictionary<string, Project>> GetAllProjects()
        {
            var response = await _client.GetAsync("/Projects");
            var allProjects = response.ResultAs<Dictionary<string, Project>>();
            return allProjects;
        }

        public async Task<bool> UpdateProject(string projectID, Project projectData)
        {
            var isUpdated = false;
            var response = await _client.SetAsync($"/Projects/{projectID}", projectData);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                isUpdated = true;
            }
            return isUpdated;
        }

        public async Task<bool> CreateNewProject(Project newProjectDtls)
        {
            bool isCreated = false;
            var response = await _client.PushAsync("/Projects", newProjectDtls);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                isCreated = true;
            }

            return isCreated;
        }

        public async Task<bool> DeleteProject(string projID)
        {
            if (string.IsNullOrEmpty(projID)) throw new ArgumentNullException();
            var response = await _client.DeleteAsync($"/Projects/{projID}");
            return response.StatusCode == System.Net.HttpStatusCode.OK;
        }
    }
}
