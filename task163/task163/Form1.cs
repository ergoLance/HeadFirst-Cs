using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task163
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string result = "";
            Echo e1 = new Echo();
            _________________________
            int x = 0;
            while (___________)
            {
                result = result + e1.Hello() + "\n";
                __________________________
            if (____________)
                {
                    e2.count = e2.count + 1;
                }
                if (____________)
                {
                    e2.count = e2.count + e1.count;
                }
                x = x + 1;
            }
            MessageBox.Show(result + "Count: " + e2.count);
        }
        class ____________
        {
            public int _________ = 0;
            public string ___________
            {
                return "helloooo...";
            }
        }
    }
}
