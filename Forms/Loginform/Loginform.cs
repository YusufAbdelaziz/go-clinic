using Microsoft.Data.SqlClient;

namespace goclinic.Forms
{
    public partial class Loginform : Form
    {
        SqlConnection con;
        public Loginform()
        {
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            //MessageBox.Show(path);
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + path + "\\Datasets\\users.mdf;Integrated Security=True;";
            con = new SqlConnection(connectionString);
            con.Open();
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
            string sqlQuery = "select count(*) from userInfo where username = '" + usernameTextBox.Texts + "' AND password = '" 
                + passwordTextBox.Texts + "';";
            SqlCommand sc = new SqlCommand(sqlQuery, con);
            string? count = sc.ExecuteScalar().ToString();
            if(count == "1")
            {
                MessageBox.Show("login successfull");
            } else
            {
                MessageBox.Show("wrong password/username");
            }
            con.Close();

        }
    }
}
