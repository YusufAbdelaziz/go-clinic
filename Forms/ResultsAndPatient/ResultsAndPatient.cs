using goclinic.customs;
using goclinic.Models;
using goclinic.Repos;
using System.ComponentModel;
using System.Reflection;

namespace goclinic
{
    public partial class ResultsAndPatient : Form
    {
        private EventHandler? GeneralPatientDetailsPanelClickEventHandler;
        private EventHandler? GeneralComplaintHistoryPanelClickEventHandler;
        private EventHandler? MedicalHistoryPanelClickEventHandler;
        private EventHandler? FamilyMedicalHistoryPanelClickHandler;
        public ResultsAndPatient()
        {
            InitializeComponent();
            if (!resultsFlowLayoutPanel.Visible && !noResultsFoundLabel.Visible && !patientDetailsPanel.Visible)
            {
                backButton.Visible = false;
            }
        }

        private void AddPatientButton(object sender, EventArgs e)
        {

            var addPatientForm = new AddPatient();
            this.Hide();
            addPatientForm.ShowDialog();
            this.Close();
        }

        private void BackButtonClick(object sender, EventArgs e)
        {
            if (resultsFlowLayoutPanel.Visible || noResultsFoundLabel.Visible)
            {

                noResultsFoundLabel.Visible = false;
                patientDetailsPanel.Visible = false;
                resultsFlowLayoutPanel.Visible = false;
                backButton.Visible = false;
            }
            else if (patientDetailsPanel.Visible)
            {
                noResultsFoundLabel.Visible = false;
                patientDetailsPanel.Visible = false;
                resultsFlowLayoutPanel.Visible = true;
            }

        }

        private void SearchForPatientsButtonClick(object sender, EventArgs? e)
        {
            if (!string.IsNullOrEmpty(phoneNumberValue.Text)) {
                resultsFlowLayoutPanel.Controls.Clear();
                resultsFlowLayoutPanel.Visible = true;
                noResultsFoundLabel.Visible = false;
                patientDetailsPanel.Visible = false;
                backButton.Visible = true;
                var patientsRepo = new PatientRepositiory();

                var patients = patientsRepo.GetPatientsByPhoneNumber(phoneNumberValue.Text);

                if (patients.Count == 0) noResultsFoundLabel.Visible = true;
                foreach (var patient in patients)
                {
                    var customCard = new CustomCard(patient);
                    customCard.showMoreButton.Click += new EventHandler((sender, e) => CardOnClick(patient));
                    resultsFlowLayoutPanel.Controls.Add(customCard);
                }
            } else
            {
                MessageBox.Show("الرجاء ادخال رقم لبدء عملية البحث");
            }
        }


        private void CardOnClick(Patient patient)
        {
            resultsFlowLayoutPanel.Visible = false;
            noResultsFoundLabel.Visible = false;
            patientDetailsPanel.Visible = true;
            PopulatePatientDetailsPanels(patient);

        }

        private void ClearAllEventHandlersFromPanels()
        {
            if (GeneralPatientDetailsPanelClickEventHandler != null && GeneralComplaintHistoryPanelClickEventHandler != null && MedicalHistoryPanelClickEventHandler != null && FamilyMedicalHistoryPanelClickHandler != null) { 
                 generalPatientDetailsPanel.Click -= GeneralPatientDetailsPanelClickEventHandler;
                generalComplaintHistoryPanel.Click -= GeneralComplaintHistoryPanelClickEventHandler;
                medicalHistoryPanel.Click -= MedicalHistoryPanelClickEventHandler;
                familyMedicalHistoryPanel.Click -= FamilyMedicalHistoryPanelClickHandler;
                GeneralPatientDetailsPanelClickEventHandler = null;
                GeneralComplaintHistoryPanelClickEventHandler = null;
                MedicalHistoryPanelClickEventHandler = null;
                FamilyMedicalHistoryPanelClickHandler = null;
            }
        }

        private void AddAllEventHandlersToPanels(Patient patient) {
            GeneralPatientDetailsPanelClickEventHandler = new EventHandler((sender, e) => GeneralPatientDetailsPanelClick(patient));
            generalPatientDetailsPanel.Click += GeneralPatientDetailsPanelClickEventHandler;
            GeneralComplaintHistoryPanelClickEventHandler = new EventHandler((sender, e) => PatientGeneralComplaintHistoryPanelClick(patient.History!.Health));
            generalComplaintHistoryPanel.Click += GeneralComplaintHistoryPanelClickEventHandler;
            MedicalHistoryPanelClickEventHandler = new EventHandler((sender, e) => PatientMedicalHistoryPanelClick(patient.History!.Illness));
            medicalHistoryPanel.Click += MedicalHistoryPanelClickEventHandler;
            FamilyMedicalHistoryPanelClickHandler = new EventHandler((sender, e) => PatientFamilyMedicalHistoryPanelClick(patient.History!.Family));
            familyMedicalHistoryPanel.Click += FamilyMedicalHistoryPanelClickHandler;
        }
        private void PopulatePatientDetailsPanels(Patient patient)
        {

            ClearAllEventHandlersFromPanels();
            AddAllEventHandlersToPanels(patient);
        }


        private void PatientGeneralComplaintHistoryPanelClick(Health health)
        {
            string dataShown = "";
            dataShown += $"التاريخ المرضي : {health.Chronic}\n";
            dataShown += $"الادوية : {health.Medication}\n";
            dataShown += $"هل تكرر المرض : {health.Repetation}\n";
            dataShown += $"هل يوجد حساسية : {health.Allergies}\n";
            MessageBox.Show(dataShown);


        }

        private void PatientFamilyMedicalHistoryPanelClick(FamilyHistory familyHistory)
        {
            string dataShown = "";
            dataShown += $"هل للعائلة أمراض مزمنة : {familyHistory.ChronicFamily}\n";
            dataShown += $"هل الوالدان على صلة قرابة : {familyHistory.ParentsRelated}\n";
            dataShown += $"التاريخ المرضي العائلي : {familyHistory.ChronicDiseases}\n";
            dataShown += $"هل يوجد نفس المرض مع الوالدين : {familyHistory.SameDiseasesWithParents}\n"; ;

            MessageBox.Show(dataShown);
        }

        private void PatientMedicalHistoryPanelClick(Illness illness)
        {
            string dataShown = "";
            dataShown += $"التاريخ الغذائي : {illness.Diet}\n";
            dataShown += $"تاريخ حديث الولادة : {illness.NewbornHistory}\n";
            dataShown += $"تاريخ الحوادث : {illness.AccidentsHistory}\n";
            dataShown += $"هل تم نقل دم للطفل : {illness.BloodTransfer}\n";
            dataShown += $"المرض الحالي : {illness.CurrentDisease}\n";
            dataShown += $"التاريخ التطوري : {illness.DevelopmentHistory}\n";

            MessageBox.Show(dataShown);
        }
        private void GeneralPatientDetailsPanelClick(Patient patient)
        {

            string dataShown = "";
            dataShown += $"الإسم : {patient.Name}\n";
            dataShown += $"النوع : {patient.Gender}\n";
            dataShown += $"نوع الدم : {patient.BloodType}\n";
            dataShown += $"رقم الهاتف : {patient.PhoneNumber}\n";
            dataShown += $"تاريخ الولادة : {patient.BirthDate}\n";
            dataShown += $"تاريخ التسجيل : {patient.RegistrationDate}\n";
            MessageBox.Show(dataShown);
        }

        private void phoneNumberValue_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) SearchForPatientsButtonClick(sender, null);
        }
    }
}