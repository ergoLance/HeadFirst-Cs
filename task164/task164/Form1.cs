using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task164
{
    public partial class Form1 : Form
    {
        Guy joe;
        Guy bob;
        int bank = 100;
        public Form1()
        {
            InitializeComponent();
            joe = new Guy();
            joe.cash = 200;
            joe.name = "Joe";

            bob = new Guy()
            {
                cash = 100,
                name = "Bob"
            };

            UpdateForm();
        }
        public void UpdateForm()
        {
            joesCashLabel.Text = joe.name + " have $" + joe.cash;
            bobsCashLabel.Text = bob.name + " have $" + bob.cash;
            bankCashLabel.Text = "Bank have $" + bank;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (bank >= 10)
            {
                bank -= joe.ReceiveCash(10);
                UpdateForm();
            }
            else
            {
                MessageBox.Show("Bank is out of money");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            bank += bob.GiveCash(5);
            UpdateForm();
        }

        private void JoeGivesToBob_Click(object sender, EventArgs e)
        {
            bob.cash += joe.GiveCash(10);
            UpdateForm();
        }

        private void BobGivesToJoe_Click(object sender, EventArgs e)
        {
            joe.cash += bob.GiveCash(5);
            UpdateForm();
        }
    }
}
