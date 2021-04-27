using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace DataAccessLibrary
{
    static class Helper
    {
        public static DatabaseOptions DatabaseOptions { get; set; } = new DatabaseOptions()
        {
            Environment = Environment.DEVELOPMENT,
            ConnectionStrings = new List<string>() { "sample connetion string" }
        };
        private static string DatabaseOptionsFileName { get; } = "dbOptions.json";

        public static string GetConnectionString()
        {
            if (File.Exists(DatabaseOptionsFileName))
            {
                DatabaseOptions = JsonConvert.DeserializeObject<DatabaseOptions>(File.ReadAllText(DatabaseOptionsFileName));
                return DatabaseOptions.ConnectionStrings[Convert.ToInt32(DatabaseOptions.Environment)];
            }
            else
            {
                WriteSampleDbOptionsContent();
                throw new FileNotFoundException("No database options json file was found");
            }
        }

        private static void WriteSampleDbOptionsContent()
        {
            string sampleJSONDbOptionsContent = JsonConvert.SerializeObject(DatabaseOptions, Formatting.Indented);
            File.WriteAllText(DatabaseOptionsFileName, sampleJSONDbOptionsContent);
        }
    }
}
