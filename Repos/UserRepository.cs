using System.Data.SqlClient;
using System.Data;
using Dapper;
using goclinic.Models;
namespace goclinic.Repos
{
    public class UserRepository
    {

        public static bool LoginQueryAndMakeUser(string username, string password)
        {
            using (IDbConnection connection = new SqlConnection(DBHelper.CnnVal("Users")))
            {
                int loginResults = connection.QuerySingle<int>($"select count(*) from userInfo where username = N'{username}' AND password = N'{password}';");

                if (loginResults == 1)
                {
                    var userId = connection.QuerySingle<int>($"select userID from userInfo where username = N'{username}' AND password = N'{password}';");
                    var phonenumber = connection.QuerySingle<string>($"select number from userInfo where username = N'{username}' AND password = N'{password}';");
                    User.Instance.InitFromData(id: userId, phoneNumber: phonenumber, name: username);
                    return true;

                }
                return false;

            }
        }

        public static bool SignUpQuery(string username, string password, string number)
        {
            using (IDbConnection connection = new SqlConnection(DBHelper.CnnVal("Users")))
            {
                int usernameExists = connection.ExecuteScalar<int>($"select count(*) from userInfo where username = N'{username}';");
                if (usernameExists == 0)
                {
                    connection.Query($"insert into userInfo(username, password, number) values( N'{username}', N'{password}', N'{number}');");
                    return false;
                }

                return true;

            }
        }
    }
}
