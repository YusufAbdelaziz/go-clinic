using System.Configuration;

namespace goclinic.Repos
{
    public class DBHelper
    {
        public static string CnnVal(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
