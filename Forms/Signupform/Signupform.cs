using System.Data.SqlClient;
using System.Data;
using Dapper;
using goclinic.Repos;

namespace goclinic.Forms
{
    public partial class Signupform : Form
    {

        public Signupform()
        {
            InitializeComponent();
        }

        private void openLoginButton_Click(object sender, EventArgs e)
        {
            Form login = new Loginform();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void createUserButton_Click(object sender, EventArgs e)
        {
            using (IDbConnection connection = new SqlConnection(DBHelper.CnnVal("Users")))
            {
                int usernameExists = connection.ExecuteScalar<int>($"select count(*) from userInfo where username = N'{usernameTextBox.Texts}';");
                if (usernameExists == 1)
                {
                    MessageBox.Show("اسم المسنخدم موجود, الرجاء اختيار اسم مستخدم اخر.");
                }
                else
                {
                    connection.Query($"insert into userInfo(username, password, number) values( N'{usernameTextBox.Texts}', N'{passwordTextBox.Texts}', N'{numberTextBox.Texts}');");
                    MessageBox.Show("تم الاضافة");
                    Form login = new Loginform();
                    this.Hide();
                    login.ShowDialog();
                    this.Close();
                }

               

            }


            //string sqlQuery = "insert into userInfo(username, password, number) values('"
            //    + usernameTextBox.Texts + "', '" + passwordTextBox.Texts + "', '" + numberTextBox.Texts + "');";
            //SqlCommand sc = new SqlCommand(sqlQuery, con);
            //sc.ExecuteNonQuery();
            //con.Close();
            
            
        }
    }
}
