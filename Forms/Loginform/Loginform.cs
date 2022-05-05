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
    }
}
