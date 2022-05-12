
using System.ComponentModel;

namespace goclinic.customs
{
    public partial class customCard : UserControl
    {
        private string? patientNameString, patientNumberString;
        private EventHandler? buttonClick;

        public customCard()
        {
            InitializeComponent();
        }

        [Category("custom")]
        public string? PatientNameString 
        { 
            get => patientNameString;
            set 
            { 
                patientNameString = value;
                patientName.Text = patientNameString;
            }
        }

        private void customCard_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        [Category("custom")]
        public string? PatientNumberString 
        {
            get => patientNumberString;
            set
            {
                patientNumberString = value;
                patientNumber.Text = patientNumberString;
            }
        }

        

        
    }
}
