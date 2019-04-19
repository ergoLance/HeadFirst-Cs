﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task195
{
    public partial class Form1 : Form
    {
        Elephant lucinda;
        Elephant lloyd;
        public Form1()
        {
            InitializeComponent();
            lucinda = new Elephant() { Name = "Lucinda", earSize = 33 };
            lloyd = new Elephant() { Name = "Lloyd", earSize = 40 };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lloyd.WhoAmI();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lucinda.WhoAmI();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Elephant one = lloyd;
            lloyd = lucinda;
            lucinda = one;
            MessageBox.Show("My ears are " + lucinda.earSize, lucinda.Name + " says...");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lloyd = lucinda;
            lloyd.earSize = 4321;
            lloyd.WhoAmI();
        }
    }

    public class Elephant
    {
        public int earSize;
        public String Name;

        public void WhoAmI()
        {
            MessageBox.Show("My ears are " + earSize, Name + " says...");
        }
    }
}
