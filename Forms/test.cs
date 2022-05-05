using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace goclinic.Forms
{
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
        }

        private void testTextButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("textBox 1: " + customTextBox1.Texts + "\n"
                + "textbox 2: " + customTextBox2.Texts + "\n"
                + "textbox 3: " + customTextBox3.Texts + "\n");
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("textBox 1: " + customTextBox1.Texts + "\n"
                + "textbox 2: " + customTextBox2.Texts + "\n"
                + "textbox 3: " + customTextBox3.Texts + "\n"
                + "textbox 4: " + customTextBox4.Texts + "\n");
        }



        //private void customeTextBox1__TextChanged(object sender, EventArgs e)
        //{
        //    //MessageBox.Show(customeTextBox1.Texts);
        //}
    }
}
