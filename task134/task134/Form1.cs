using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task134
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            while (Visible)
            {
                int r = random.Next(1, 255);
                int g = random.Next(1, 255);
                int b = random.Next(1, 255);
                this.BackColor = Color.FromArgb(r, g, b);
                Application.DoEvents();
                System.Threading.Thread.Sleep(300);
            }
        }
    }
}
