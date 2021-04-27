using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary
{
    class DatabaseOptions
    {
        public Environment Environment { get; set; } = Environment.DEVELOPMENT;
        public List<string> ConnectionStrings { get; set; } = new List<string>();
    }
}
