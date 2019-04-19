using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task185
{
    public partial class Form1 : Form
    {
        double milesTraveled, reimburseRate = 0.39, amountOwed;

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(milesTraveled + " miles", "Miles Traveled");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (startingMileage.Value < endingMileage.Value )
            {
                milesTraveled = (double)endingMileage.Value - (double)startingMileage.Value;
                amountOwed = milesTraveled * reimburseRate;
                label4.Text = "$" + amountOwed;

            }
            else
            {
                MessageBox.Show("Starting mileage cant be more than ending mileage!", "Cannot calculate mileage");
            }
        }

        public Form1()
        {
            InitializeComponent();
        }
    }
}
