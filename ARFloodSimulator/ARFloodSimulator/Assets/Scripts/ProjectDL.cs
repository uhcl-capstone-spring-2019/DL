using SWEN5232.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace SWEN5232.DataLayer
{
    /// <summary>
    /// Class to save/fetch data related to Projects.
    /// </summary>
    public class ProjectDL
    {
        /// <summary>
        /// Method to save whole project into firebase.
        /// </summary>
        /// <param name="project">Project object</param>
        /// <returns>True if saved successfully otherwise false.</returns>
        public async Task<bool> Save_Project(Project project)
        {
            if (project == null)
                throw new ArgumentNullException("project");

            bool isSaved = false;

            project.ProjectID = Guid.NewGuid().ToString();
            var json = JsonUtility.ToJson(project);

            await FirebaseManager.dataRef.Child("Projects").Child(project.ProjectID).SetRawJsonValueAsync(json).ContinueWith(T =>
            {
                if (!T.IsFaulted && T.IsCompleted && T.Exception == null)
                    isSaved = true;
            });

            if (isSaved)
            {
                Debug.Log("Project details saved with id : " + project.ProjectID);
            }

            return isSaved;
        }

        /// <summary>
        /// Method to delete project from firebase based on project ID.
        /// </summary>
        /// <param name="project">Project Obj with project ID.</param>
        /// <returns>Returns true if project is deleted successfully otherwise false.</returns>
        public async Task<bool> Delete_Project(Project project)
        {

            if (project == null)
                throw new ArgumentNullException("project");

            if (string.IsNullOrEmpty(project.ProjectID))
                throw new ArgumentNullException("ProjectID");

            bool isDeleted = false;

            await FirebaseManager.dataRef.Child("Projects").Child(project.ProjectID).RemoveValueAsync().ContinueWith(T =>
            {
                if (!T.IsFaulted && T.IsCompleted && T.Exception == null)
                    isDeleted = true;
            });

            return isDeleted;
        }

        /// <summary>
        /// Method to get the project data by project id from firebase.
        /// </summary>
        /// <param name="projectId"></param>
        /// <returns></returns>
        public async Task<Project> Open_Project(string projectId)
        {
            if (projectId == null) throw new ArgumentNullException("projectId");

            Project projectData = null;

            var snapshot = await FirebaseManager.dataRef.Child("Projects").Child(projectId).GetValueAsync();

            if (snapshot.Value != null)
            {
                var projectDict = snapshot.Value as Dictionary<string, object>;
                var json = snapshot.GetRawJsonValue();
                projectData = JsonUtility.FromJson<Project>(json);
            }
            else
            {
                Debug.Log($"Project with id {projectId} not found.");
            }

            return projectData;
        }

    }
}
