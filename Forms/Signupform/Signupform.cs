using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
