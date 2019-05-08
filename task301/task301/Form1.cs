using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task301
{
    public partial class Form1 : Form
    {
        private Queen queen;
        public Form1()
        {
            InitializeComponent();
            workerBeeJob.SelectedIndex = 0;
            Worker[] workers = new Worker[4];            
            workers[0] = new Worker(new string[] { "Nectar collector", "Honey manufactoring"});
            workers[1] = new Worker(new string[] { "Egg care", "Baby bee tutoring"});
            workers[2] = new Worker(new string[] { "Hive maintence", "Sting patrol"});
            workers[3] = new Worker(new string[] { "Nectar collector", "Honey manufactoring","Egg care", "Baby bee tutoring", "Hive maintence", "Sting patrol"});        
            queen = new Queen(workers);            
        }
        private void assignJob_Click(object sender, EventArgs e)
        {
            if (queen.AssignWork(workerBeeJob.Text, (int)shifts.Value) == false)
                MessageBox.Show("Для этого задания рабочих нет ‘"
                + workerBeeJob.Text + "’", "Матка говорит...");
            else
                MessageBox.Show("Задание ‘" + workerBeeJob.Text + "’ будет закончено через "
                + shifts.Value + " смен", "Матка говорит...");
        }
        private void nextShift_Click(object sender, EventArgs e)
        {
            report.Text = queen.WorkTheNextShift();
        }
    }
}
