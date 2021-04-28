using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary.Handlers
{
    public class ProjectsHandler
    {
        public List<Project> GetProjectsOfUser(int userId)
        {
            string command = "select * from ProjectsTable where UserId = @UserId";
            DataAccess<Project, object> dataAccess = new DataAccess<Project, object>();

            List<Project> ProjectsFound = dataAccess.GetData(command, new { UserId = userId });
            return ProjectsFound;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>A project with specified Id</returns>
        public List<Project> GetProject(int id)
        {
            string command = "select * from ProjectsTable where Id = @Id";
            DataAccess<Project, object> dataAccess = new DataAccess<Project, object>();

            List<Project> ProjectsFound = dataAccess.GetData(command, new { Id = id });
            return ProjectsFound;
        }

        /// <summary>
        /// Inserts new project into the ProjectsTable
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="name"></param>
        /// <returns>True if operation was successful, returns false if otherwise</returns>
        public bool InsertProject(int userId, string title)
        {
            DateTime now = DateTime.Now;

            string command = "insert into ProjectsTable(UserId, Title) " +
                "values (@UserId, @Title)";
            DataAccess<Project, object> dataAccess = new DataAccess<Project, object>();

            int rowsAffected = dataAccess.WriteData(command,
                new { UserId = userId, Title = title }); ;

            if (rowsAffected == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
