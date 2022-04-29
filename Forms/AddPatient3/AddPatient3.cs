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
    public partial class AddPatient3 : Form
    {
        public AddPatient3()
        {
            InitializeComponent();
        }

        private void backHomeButton2_Click(object sender, EventArgs e)
        {
            // AddPatient3 form Back button
            this.Hide();                                         //Hide AddPatient2 form
            AddPatient2 NewSign = new AddPatient2();            //Creat an object from AddPatient1 form
            NewSign.ShowDialog();                              //Display the AddPatient1 form 
            this.Close();                                     //Close the AddPatient2 form
        }

        private void firstNextStebButton2_Click(object sender, EventArgs e)
        {
            // AddPatient3 form Next button
            this.Hide();                                         //Hide AddPatient2 form
            AddPatient4 NewSign = new AddPatient4();            //Creat an object from AddPatient1 form
            NewSign.ShowDialog();                              //Display the AddPatient1 form 
            this.Close();                                     //Close the AddPatient2 form
        }
    }
}
