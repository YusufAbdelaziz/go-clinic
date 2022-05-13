using System.Data.SqlClient;
using System.Data;
using Dapper;
using goclinic.Repos;
using System.Linq;
using goclinic.Models;

namespace goclinic.Forms
{
    public partial class Loginform : Form
    {
        public Loginform()
        {
            InitializeComponent();
        }

        private void openSignupButton_Click(object sender, EventArgs e)
        {
            Form signup = new Signupform();
            this.Hide();
            signup.ShowDialog();
            this.Close();
        }

        private void signinButton_Click(object sender, EventArgs e)
        {
            using (IDbConnection connection = new SqlConnection(DBHelper.CnnVal("Users")))
            {

               

                int loginResults = connection.QuerySingle<int>($"select count(*) from userInfo where username = N'{usernameTextBox.Texts}' AND password = N'{passwordTextBox.Texts}';");
               
                if (loginResults == 1)
                {
                    var userId = connection.QuerySingle<int>($"select userID from userInfo where username = N'{usernameTextBox.Texts}' AND password = N'{passwordTextBox.Texts}';");
                    var phonenumber = connection.QuerySingle<string>($"select number from userInfo where username = N'{usernameTextBox.Texts}' AND password = N'{passwordTextBox.Texts}';");
                    User user = new User(id: userId, phoneNumber: phonenumber, password: passwordTextBox.Texts, username: usernameTextBox.Texts);
                    MessageBox.Show("تم الدخول بنجاح");
                    Form resultsAndPatients = new ResultsAndPatient();
                    this.Hide();
                    resultsAndPatients.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("اسم المستخدم خطأ او كلمة السر");
                }

            }

        }
    }
}
