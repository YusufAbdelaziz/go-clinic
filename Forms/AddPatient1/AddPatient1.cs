using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace goclinic
{
    public partial class AddPatient1 : Form
    {
        public AddPatient1()
        {
            InitializeComponent();
        }

        private void firstNextStebButton2_Click(object sender, EventArgs e)
        {
            // AddPatient1 form Next button
            this.Hide();                                         //Hide the AddPatient1 form
            AddPatient2 NewSign = new AddPatient2();            //Creat an object from AddPatient2 form
            NewSign.ShowDialog();                              //Display the AddPatient2 form
            this.Close();                                     //Close the AddPatient1 form

        }
    }
}
