using Microsoft.Data.SqlClient;


namespace goclinic.Forms
{
    public partial class Signupform : Form
    {

        SqlConnection con;
        public Signupform()
        {
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            //MessageBox.Show(path);
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename="+path+"\\Datasets\\users.mdf;Integrated Security=True;";
            con = new SqlConnection(connectionString);
            con.Open();
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
            string sqlQuery = "insert into userInfo(username, password, number) values('"
                + usernameTextBox.Texts + "', '" + passwordTextBox.Texts + "', '" + numberTextBox.Texts + "');";
            SqlCommand sc = new SqlCommand(sqlQuery, con);
            sc.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Added");
            
        }
    }
}
