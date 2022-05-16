
using System.ComponentModel;


/* 
 * to use this as multiline enable the feature then expand the size for it to work
 * VERY IMPORTANT: when making a multiline textbox into a normal one 
 * resize it down first before making it false if you dont it might bug a little
*/


namespace goclinic.customs
{
    [DefaultEvent("_TextChanged")]
    public partial class customTextBox : UserControl
    {
        [DefaultValue(0)]
        private int radius = 0;
        [DefaultValue(false)]
        private bool textAlignRight;


#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public customTextBox()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            InitializeComponent();
        }

        public event EventHandler _TextChanged;

        [Category("Custom")]
        public int Radius 
        { 
            get => radius;
            set 
            { 
                if(value > 0)
                {
                    radius = value;
                    this.RecreateRegion();
                }
                
            }
        }

        [Category("Custom")]
        public bool TextAlignRight
        {
            get => textAlignRight;
            set
            {
                if (value)
                {
                    textAlignRight = value;
                    textBox1.TextAlign = HorizontalAlignment.Right;
                }
                else
                {
                    textAlignRight = value;
                    textBox1.TextAlign = HorizontalAlignment.Left;
                }

            }
        }


        [Category("Custom")]
        public string PlaceholderText
        {
            get { return textBox1.PlaceholderText; }
            set { textBox1.PlaceholderText = value; }
        }

        [Category("Custom")]
        public string Texts
        {
            get { return textBox1.Text; }
            //set { textBox1.Text = value; }
        }

        [Category("Custom")]
        public bool PasswordChar
        {
            get { return textBox1.UseSystemPasswordChar; }
            set { textBox1.UseSystemPasswordChar = value; }
        }

        [Category("Custom")]
        public bool Multiline
        {
            get { return textBox1.Multiline; }
            set { textBox1.Multiline = value; }
        }

        [Category("Custom")]
        public override Color ForeColor
        {
            get { return base.ForeColor; }
            set
            {
                base.ForeColor = value;
                textBox1.ForeColor = value;
            }
        }

        [Category("Custom")]
        public override Font Font
        {
            get { return base.Font; }
            set
            {
                base.Font = value;
                textBox1.Font = value;
                if (this.DesignMode)
                    UpdateControlHeight();
            }
        }

        

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
       private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect,
        int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        private void RecreateRegion()
        {
            var bounds = ClientRectangle;
            if(radius >= 1)
            {
                this.Region = Region.FromHrgn(CreateRoundRectRgn(bounds.Left, bounds.Top,
                bounds.Right, bounds.Bottom, radius, radius));
            }
            else
            {
                Rectangle rectSurface = this.ClientRectangle;
                this.Region = new Region(rectSurface);
            }
            
            //Better round rectangle
            
            this.Invalidate();
        }

        private void UpdateControlHeight()
        {
            if (textBox1.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                textBox1.Multiline = true;
                textBox1.MinimumSize = new Size(0,36);
                textBox1.Multiline = false;
                this.Height = 36 + this.Padding.Top + this.Padding.Bottom;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (_TextChanged != null)
                _TextChanged.Invoke(sender, e);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
             this.RecreateRegion();
           
            if (this.DesignMode)
                UpdateControlHeight();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }

        

    }
}
