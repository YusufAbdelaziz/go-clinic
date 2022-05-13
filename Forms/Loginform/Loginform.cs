using System.Data.SqlClient;
using System.Data;
using Dapper;
using goclinic.Repos;
using System.Linq; 

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
                
                int loginResults = connection.ExecuteScalar<int>($"select count(*) from userInfo where username = '{usernameTextBox.Texts}%' AND password = '{passwordTextBox.Texts}%';");
               
                if (loginResults == 1)
                {
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



            //string sqlQuery = "select count(*) from userInfo where username = '" + usernameTextBox.Texts + "' AND password = '" 
            //    + passwordTextBox.Texts + "';";
            //SqlCommand sc = new SqlCommand(sqlQuery, con);
            //string? count = sc.ExecuteScalar().ToString();
            //if(count == "1")
            //{
            //    MessageBox.Show("login successfull");
            //} else
            //{
            //    MessageBox.Show("wrong password/username");
            //}
            //con.Close();

        }
    }
}
