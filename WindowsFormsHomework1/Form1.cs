using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsHomework1
{
    public partial class Form1 : Form
    {
        int sec = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.BackColor = Color.Red;
            label1.Text = "Ви виграли";
            timer1.Start();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Random r = new Random();
            Point mouseLoc = e.Location;
            Point labLoc = label1.Location;
           
            if (mouseLoc.X >= labLoc.X - 5 && mouseLoc.X <= labLoc.X)
                label1.Location = new Point(labLoc.X + 5, labLoc.Y);
            if (mouseLoc.X <= labLoc.X + label1.Width + 5 && mouseLoc.X >= labLoc.X)
                label1.Location = new Point(labLoc.X - 5, labLoc.Y);
            if (mouseLoc.Y >= labLoc.Y - 5 && mouseLoc.Y <= labLoc.Y)
                label1.Location = new Point(labLoc.X, labLoc.Y + 5);
            if (mouseLoc.Y <= labLoc.Y + label1.Height + 5 && mouseLoc.Y >= labLoc.Y)
                label1.Location = new Point(labLoc.X, labLoc.Y - 5);

            if (label1.Left < 5)
            { label1.Left = 5; }
            if ((label1.Left + label1.Width) > this.ClientSize.Width - 5)
            { label1.Left = this.ClientSize.Width - label1.Width - 5; }
            if (label1.Top < 5)
            { label1.Top = 5; }
            if ((label1.Top + label1.Height) > this.ClientSize.Height - 5)
            { label1.Top = this.ClientSize.Height - label1.Height - 5; }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltime.Text = (++sec).ToString();
            if (sec == 10)
            {
                label1.BackColor = Color.Lime;
                label1.Text = "Злови мене";
                timer1.Stop();
                sec = 0;
            }
        }
    }
}
