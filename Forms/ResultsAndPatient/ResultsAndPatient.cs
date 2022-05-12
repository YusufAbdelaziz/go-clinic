using goclinic.customs;
using goclinic.Forms;
using goclinic.Repos;

namespace goclinic
{
    public partial class ResultsAndPatient : Form
    {
        public ResultsAndPatient()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void showMoreButton_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void searchPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void phoneNumberValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void generalPatientDetailsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GeneralPatientDetailsPanelClick(object sender, EventArgs e) 
        {
            var popupForm = new popupForm();
            popupForm.ShowDialog();
        }

        private void patientPhoneNumber_Click(object sender, EventArgs e)
        {

        }


        private void SearchForPatientsButton(object sender, EventArgs e)
        {
            var patientsRepo = new PatientRepositiory();

            var patients = patientsRepo.GetPatientsByPhoneNumber(phoneNumberValue.Text);

            foreach (var patient in patients) {
                resultsFlowLayoutPanel.Controls.Add(new CustomCard(patient));
            }
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }
    }
}