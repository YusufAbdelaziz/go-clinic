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
            
            AddPatient1Container.Hide();
            steps1Container.Hide();
            AddPatient2Container.Show();
            steps2Container.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // AddPatient4 form Back button
            this.Hide();                                         //Hide AddPatient2 form
            PatientdAdded NewSign = new PatientdAdded();            //Creat an object from AddPatient1 form
            NewSign.ShowDialog();                              //Display the AddPatient1 form 
            this.Close();                                     //Close the AddPatient2 form
        }




        private void backButton2_Click(object sender, EventArgs e)
        {
            AddPatient2Container.Hide();
            steps1Container.Hide();
            AddPatient1Container.Show();
            steps1Container.Show();
        }

        private void nextButton2_Click(object sender, EventArgs e)
        {
            AddPatient2Container.Hide();
            AddPatient3Container.Show();
            steps2Container.Hide();
            steps3Container.Show();
        }

        private void backButton3_Click(object sender, EventArgs e)
        {
            AddPatient3Container.Hide();
            AddPatient2Container.Show();
            steps3Container.Hide();
            steps2Container.Show();
        }

        private void nextButton3_Click(object sender, EventArgs e)
        {
            AddPatient3Container.Hide();
            AddPatient4Container.Show();
            steps3Container.Hide();
            steps4Container.Show();
        }

        private void backButton4_Click(object sender, EventArgs e)
        {
            AddPatient4Container.Hide();
            AddPatient3Container.Show();
            steps4Container.Hide();
            steps3Container.Show();
        }
    }
}
