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
    public partial class AddPatient2 : Form
    {
        public AddPatient2()
        {
            InitializeComponent();
        }



        private void firstNextStebButton2_Click(object sender, EventArgs e)
        {
            // AddPatient2 form Next button
            this.Hide();                                         //Hide AddPatient2 form
            AddPatient3 NewSign = new AddPatient3();            //Creat an object from AddPatient1 form
            NewSign.ShowDialog();                              //Display the AddPatient1 form 
            this.Close();                                     //Close the AddPatient2 form
        }
        private void firstBackStebButton2_Click(object sender, EventArgs e)
        {
            // AddPatient2 form back button
            this.Hide();                                         //Hide AddPatient2 form
            AddPatient1 NewSign = new AddPatient1();            //Creat an object from AddPatient1 form
            NewSign.ShowDialog();                              //Display the AddPatient1 form 
            this.Close();                                     //Close the AddPatient2 form

        }
    }
}
