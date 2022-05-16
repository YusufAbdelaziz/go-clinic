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

    public partial class PatientdAdded : Form

    {
        private System.Windows.Forms.Timer tmr;

        public PatientdAdded()
        {
            InitializeComponent();
            tmr = new System.Windows.Forms.Timer();
            tmr.Tick += delegate {
                this.Close();
            };
            tmr.Interval = (int)TimeSpan.FromMilliseconds(3000).TotalMilliseconds;
            tmr.Start();
        }

        private void successfully_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
