using System.Data.SqlClient;
using System.Data;
using Dapper;
using goclinic.Repos;
using goclinic.Models;

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
                int usernameExists = connection.ExecuteScalar<int>($"select count(*) from userInfo where username = '{usernameTextBox.Texts}%';");
                if (usernameExists == 1)
                {
                    MessageBox.Show("اسم المسنخدم موجود, الرجاء اختيار اسم مستخدم اخر.");
                }
                else
                {
                    var userId = connection.QuerySingle<int>($"insert into userInfo(username, password, number) output inserted.userID values( '{usernameTextBox.Texts}%', '{passwordTextBox.Texts}%', '{numberTextBox.Texts}%');");
                    User user = new User(id: userId, phoneNumber: numberTextBox.Texts, password: passwordTextBox.Texts, username: usernameTextBox.Texts);
                    MessageBox.Show("تم الاضافة");
                    Form login = new Loginform();
                    this.Hide();
                    login.ShowDialog();
                    this.Close();
                }

            }  
        }
    }
}
