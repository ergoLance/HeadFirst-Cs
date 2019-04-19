using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task207
{
    public partial class Form1 : Form
    {
        string[] islands = new string[4];
        int[] index = new int[4];
        string result = "";

        public Form1()
        {
            InitializeComponent();
            islands[0] = "Bermuda";
            islands[1] = "Fiji";
            islands[2] = "Azores";
            islands[3] = "Cozumel";

            index[0] = 1;
            index[1] = 3;
            index[2] = 0;
            index[3] = 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int y = 0;
            int refNum;

            while (y < 4)
            {
                refNum = index[y];
                result += "\nisland = ";
                result += islands[refNum];
                y += 1;
            }
            MessageBox.Show(result);
        }
    }
}
