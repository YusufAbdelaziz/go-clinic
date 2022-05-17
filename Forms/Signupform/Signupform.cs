
using goclinic.Repos;

namespace goclinic.Forms
{
    public partial class تسجيل : Form
    {

        public تسجيل()
        {
            InitializeComponent();
        }

        private void OpenLoginButtonClick(object sender, EventArgs e)
        {
            Form login = new Loginform();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void CreateUserButtonClick(object sender, EventArgs e)
        {
            bool usernameExists = UserRepository.SignUpQuery(username: usernameTextBox.Texts, password: passwordTextBox.Texts, number: numberTextBox.Texts);
                if (usernameExists)
                {
                    MessageBox.Show("اسم المسنخدم موجود, الرجاء اختيار اسم مستخدم اخر.");
                }
                else
                { 
                    MessageBox.Show("تم الاضافة");
                    Form login = new Loginform();
                    this.Hide();
                    login.ShowDialog();
                    this.Close();
                }

            
        }
    }
}
