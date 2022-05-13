using goclinic.Models;

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

            if (String.IsNullOrEmpty(nameTextBox.Text) || String.IsNullOrEmpty(phoneTextBox.Text)
                || String.IsNullOrEmpty(genderComboBox2.ToString()) || String.IsNullOrEmpty(bloodComboBox.ToString()))
            {
                MessageBox.Show("Please Enter All The Fields");
            }
            else
            {
                AddPatient1Container.Hide();
                steps1Container.Hide();
                AddPatient2Container.Show();
                steps2Container.Show();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(RelativesComboBox.ToString()) || String.IsNullOrEmpty(ChronicDiseaseInFamilyComboBox.ToString())
                || String.IsNullOrEmpty(ChronicDiseasesInFamilyTextBox.Text) || String.IsNullOrEmpty(CurrentInFamilyComboBox.ToString()))
            {
                MessageBox.Show("Please Enter All The Fields");
            }
            else
            {
                Patient patient = getDataForm();
                //MessageBox.Show(viewData(patient));
                // AddPatient4 form Back button
                this.Hide();                                         //Hide AddPatient2 form
                PatientdAdded NewSign = new PatientdAdded();            //Creat an object from AddPatient1 form
                NewSign.ShowDialog();                              //Display the AddPatient1 form 
                this.Close();


            }
            //Close the AddPatient2 form
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
            if (String.IsNullOrEmpty(currentDiseaseTextBox.Text) || String.IsNullOrEmpty(nutritionalHistoryTextBox.Text)
                || String.IsNullOrEmpty(newBornTextBox.Text) || String.IsNullOrEmpty(developmentTextBox.Text)
                || String.IsNullOrEmpty(accidentsTextBox.Text) || String.IsNullOrEmpty(bloodComboBox.ToString()))
            {
                MessageBox.Show("Please Enter All The Fields");
            }
            else
            {
                AddPatient2Container.Hide();
                AddPatient3Container.Show();
                steps2Container.Hide();
                steps3Container.Show();
            }

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

            if (String.IsNullOrEmpty(medicationTextBox.Text) || String.IsNullOrEmpty(chronicDiseasesTextBox.Text)
                || String.IsNullOrEmpty(RepetitionComboBox.ToString()) || String.IsNullOrEmpty(allergyTextBox.Text))
            {
                MessageBox.Show("Please Enter All The Fields");
            }
            else
            {
                AddPatient3Container.Hide();
                AddPatient4Container.Show();
                steps3Container.Hide();
                steps4Container.Show();
            }

        }

        private void backButton4_Click(object sender, EventArgs e)
        {
            AddPatient4Container.Hide();
            AddPatient3Container.Show();
            steps4Container.Hide();
            steps3Container.Show();
        }

        private bool MapStringToBool(string? text)
        {
            if (text == "Yes") return true;
            return false;
        }


        private Patient getDataForm()
        {

            Illness illness = new Illness(currentDisease: currentDiseaseTextBox.Text, diet: nutritionalHistoryTextBox.Text,
                newbornHistory: newBornTextBox.Text, developmentHistory: developmentTextBox.Text,
                accidentsHistory: accidentsTextBox.Text, bloodTransfer: MapStringToBool(bloodTransferComboBox.SelectedItem.ToString()));

            Health health = new Health(chronic: chronicDiseasesTextBox.Text, repetation: MapStringToBool(RepetitionComboBox.SelectedItem.ToString()),
                medication: medicationTextBox.Text, allergies: allergyTextBox.Text);


            FamilyHistory familyHistory = new FamilyHistory(parentsRelated: MapStringToBool(RelativesComboBox.SelectedItem.ToString()),
                chronicDiseases: ChronicDiseasesInFamilyTextBox.Text, sameDiseasesWithParents: MapStringToBool(CurrentInFamilyComboBox.SelectedItem.ToString()),
                chronicFamily: MapStringToBool(ChronicDiseaseInFamilyComboBox.SelectedItem.ToString()));

            History history = new History(illness: illness, health: health, family: familyHistory);


            Patient patient = new Patient(name: nameTextBox.Text, birthDate: dateBirthPicker.Value,
            gender: Patient.MapStringToGender(genderComboBox2.SelectedItem.ToString()),
            bloodType: Patient.MapStringToBloodType(bloodComboBox.SelectedItem.ToString()),
            phoneNumber: phoneTextBox.Text, registrationDate: logIndatePicker.Value,
            history: history);

            return patient;
        }

    }
}
