using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace goclinic.customs
{
    class CustomButton : Button
    {
        //Fields
        [DefaultValue(20)]
        private int radius = 20;

        //Properties
        

        [Category("custom")]
        public int Radius
        {
            get { return radius; }
            set
            {
                if (value > 0)
                {
                    radius = value;
                    this.RecreateRegion();
                }

            }
        }

        
        public CustomButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            this.BackColor = Color.MediumSlateBlue;
            this.ForeColor = Color.White;
            this.Resize += new EventHandler(Button_Resize);
        }

        private void Button_Resize(object? sender, EventArgs e)
        {
            if (radius > this.Height)
                radius = this.Height;
            this.RecreateRegion();
        }


        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect,
        int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        private void RecreateRegion()
        {
            var bounds = ClientRectangle;
            if (radius >= 1)
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


    }
}
