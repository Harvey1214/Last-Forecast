using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Dapper;
using Dapper.Contrib;

namespace DataAccessLibrary
{
    class DataAccess<T, U>
    {
        /// <summary>
        /// Selects data from a table according to the command
        /// </summary>
        /// <param name="command"></param>
        /// <param name="parameters"></param>
        /// <returns>A list of requested objects with the data from the SELECT command</returns>
        public List<T> GetData(string command, U parameters)
        {
            using (IDbConnection connection = new SqlConnection(Helper.GetConnectionString()))
            {
                var output = connection.Query<T>(command, parameters).AsList();

                if (output.Count > 0)
                {
                    return output;
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Selects data from a table according to the command
        /// </summary>
        /// <param name="command"></param>
        /// <param name="parameters"></param>
        /// <returns>A list of requested objects with the data from the SELECT command</returns>
        public List<T> GetData(string command)
        {
            using (IDbConnection connection = new SqlConnection(Helper.GetConnectionString()))
            {
                var output = connection.Query<T>(command).AsList();

                if (output.Count > 0)
                {
                    return output;
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Inserts, updates, or otherwise modifies table data
        /// </summary>
        /// <param name="command"></param>
        /// <param name="parameters"></param>
        /// <returns>The number of rows affected by the command</returns>
        public int WriteData(string command, U parameters)
        {
            using (IDbConnection connection = new SqlConnection(Helper.GetConnectionString()))
            {
                return connection.Execute(command, parameters);
            }
        }
    }
}
