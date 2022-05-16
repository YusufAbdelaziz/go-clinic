
using goclinic.Models;

namespace goclinic.customs
{
    public partial class CustomCard : UserControl
    {
        private readonly Patient patient;

        public CustomCard(Patient patient)
        {
            InitializeComponent();
            this.patient = patient;
            patientNameLabel.Text = patient.Name;
            patientNumberPanel.Text = patient.PhoneNumber;
        }

       // [Category("custom")]
       // public string? PatientNameString
       // {
       //     get => this.patient.Name;
       //     set
       //     {
       //         this.patient.Name = value;
       //         patientNameLabel.Text = this.patient.Name;
       //     }
       // }

    


      // [Category("custom")]
      // public string? PatientNumberString
      // {
      //     get => this.patient.PhoneNumber;
      //     set
      //     {
      //         this.patient.PhoneNumber = value;
      //         patientNumberPanel.Text = this.patient.PhoneNumber;
      //     }
      // }




    }
}
