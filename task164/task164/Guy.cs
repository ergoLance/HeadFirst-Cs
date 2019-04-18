using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task164
{
    class Guy
    {
        public string name;
        public int cash;

        public int GiveCash(int amount)
        {
            if (amount <= cash && amount > 0)
            {
                cash -= amount;
                return amount;
            }
            else
            {
                MessageBox.Show("I dont have enough money " + amount, name + " telling...");
                return 0;
            }
        }

        public int ReceiveCash(int amount)
        {
            if (amount > 0)
            {
                cash += amount;
                return amount;
            }
            else
            {
                MessageBox.Show(amount + " dont need", name + " telling...");
                return 0;
            }
        }
        

        
    }
}
