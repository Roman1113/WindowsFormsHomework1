using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "Загадайте число від 1 до 2000.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int min = 1;
            int max = 2000;
            int quantity = 0;
            string caption = "Вгадай число";
            while (true)
            {
                quantity++;
                int mid = (max + min) / 2;
                string text = "Твоє число більше ніж " + mid as string;
                DialogResult res = MessageBox.Show(text, caption, MessageBoxButtons.YesNoCancel);

                if (res == DialogResult.Yes)
                    min = mid + 1;
                else
                    max = mid;
                if (min == max)
                    break;
                if (res == DialogResult.Cancel)
                    Environment.Exit(0);
            }
            string tmp = "Твоє число:   " + min + "\nКількість спроб: " + quantity;
            MessageBox.Show(tmp, caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
    }
}
