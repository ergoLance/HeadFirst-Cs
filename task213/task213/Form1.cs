using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task213
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        LabelBouncer[] bouncers = new LabelBouncer[3];

        private void ToggleBouncing(int index, Label labelToBounce)
        {
            if (bouncers[index] == null)
            {
                bouncers[index] = new LabelBouncer();
                bouncers[index].MyLabel = labelToBounce;
            }
            else
            {
                bouncers[index] = null;
            }
        }



        private void Timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0;i < 3; i++)
            {
                if (bouncers[i] != null)
                {
                    bouncers[i].Move();
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ToggleBouncing(0, label1);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ToggleBouncing(0, label2);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            ToggleBouncing(0, label3);
        }
    }
}
