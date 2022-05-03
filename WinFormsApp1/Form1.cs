



using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
    
namespace WinFormsApp1
{
    
        public partial class Form1 : Form
    {
        


        public Form1()
        {   
            InitializeComponent();
            panel1.Left = Screen.PrimaryScreen.Bounds.Width/ 4;
            panel1.Top = Screen.PrimaryScreen.Bounds.Height / 3;

            closingButton.Top = 0;
            closingButton.Left = Screen.PrimaryScreen.Bounds.Width - 64;

         }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String searched = searchBar.Text;
            MessageBox.Show("You searched for " + searched);
        }

        private void AddPatient_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hello");
            //Application.Run(new Form1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}