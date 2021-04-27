using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary.Handlers
{
    class UsersHandler
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="email"></param>
        /// <returns>A list of users with the specified email address</returns>
        public List<User> GetUsers(string email)
        {
            string command = "select * from UsersTable where Email = @Email";
            DataAccess<User, object> dataAccess = new DataAccess<User, object>();

            List<User> usersFound = dataAccess.GetData(command, new { Email = email });
            if (usersFound != null) usersFound.ForEach(o => o.Decrypt());
            return usersFound;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>A list of users with the specified Id</returns>
        public List<User> GetUsers(int id)
        {
            string command = "select * from UsersTable where Id = @Id";
            DataAccess<User, object> dataAccess = new DataAccess<User, object>();

            List<User> usersFound = dataAccess.GetData(command, new { Id = id });
            if (usersFound != null) usersFound.ForEach(o => o.Decrypt());
            return usersFound;
        }

        /// <summary>
        /// Inserts a new user into the UsersTable
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns>True if operation was successful, returns false otherwise</returns>
        public bool InsertUser(string email, string password)
        {
            string command = "insert into UsersTable(Email, Password) values (@Email, @Password)";
            DataAccess<User, object> dataAccess = new DataAccess<User, object>();

            int rowsAffected = dataAccess.WriteData(command, new { Email = email, Password = Security.Encrypt(password) });

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
