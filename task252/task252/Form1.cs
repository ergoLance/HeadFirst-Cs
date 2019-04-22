using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task252
{
    public partial class Form1 : Form
    {
        CableBill january, february, march;
        public Form1()
        {
            InitializeComponent();
            //january = new CableBill(4);
            //MessageBox.Show(january.CalculateAmount(7).ToString());
            //february = new CableBill(7);
            //MessageBox.Show(february.CalculateAmount(3).ToString());
            march = new CableBill(9);
            march.Discount = true;
            MessageBox.Show(march.CalculateAmount(6).ToString());
        }
    }
}
