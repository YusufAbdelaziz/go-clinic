
using goclinic.Repos;

namespace goclinic.Forms
{
    public partial class SignupForm : Form
    {

        public SignupForm()
        {
            InitializeComponent();
        }

        private void OpenLoginButtonClick(object sender, EventArgs e)
        {
            Form login = new LoginForm();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void CreateUserButtonClick(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(usernameTextBox.Texts) || String.IsNullOrEmpty(passwordTextBox.Texts) || String.IsNullOrEmpty(numberTextBox.Texts))
            {
                MessageBox.Show("من فضلك ادخل جميع البيانات المطلوبة");
            }
            else
            {
                bool usernameExists = UserRepository.SignUpQuery(username: usernameTextBox.Texts, password: passwordTextBox.Texts, number: numberTextBox.Texts);
                if (usernameExists)
                {
                    MessageBox.Show("اسم المسنخدم موجود, الرجاء اختيار اسم مستخدم اخر.");
                }
                else
                {
                    MessageBox.Show("تم الاضافة");
                    Form login = new LoginForm();
                    this.Hide();
                    login.ShowDialog();
                    this.Close();
                }
            }
            

            
        }
    }
}
