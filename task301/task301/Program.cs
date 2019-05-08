using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task301
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    class Queen
    {
        public Queen(Worker[] workers)
        {
            this.workers = workers;
        }
        private Worker[] workers;
        private int shiftNumber = 0;
        public bool AssignWork(string job, int numberOfShifts)
        {
            for (int i = 0; i < workers.Length; i++)
                if (workers[i].DoThisJob(job, numberOfShifts))
                    return true;
            return false;
        }
        public string WorkTheNextShift()
        {
            shiftNumber++;
            string report = "Отчет для смены#" + shiftNumber + "\r\n";
            for (int i = 0; i < workers.Length; i++)
            {
                if (workers[i].DidYouFinish())
                    report += "Рабочий #" + (i + 1) + " закончил работу\r\n";
                if (String.IsNullOrEmpty(workers[i].CurrentJob))
                    report += "Рабочий #" + (i + 1) + " не работает\r\n";
                else
                if (workers[i].ShiftsLeft > 0)
                    report += "Рабочий #" + (i + 1) + " выполняет ‘" + workers[i].CurrentJob
                    + "’ еще " + workers[i].ShiftsLeft + " смен\r\n";
                else
                    report += "Рабочий #" + (i + 1) + " закончит ‘"
                    + workers[i].CurrentJob + "’ после этой смены\r\n";
            }
            return report;
        }
        }

    class Worker
    {
        public Worker(string[] jobsICanDo)
        {
            this.jobsICanDo = jobsICanDo;
        }
        public int ShiftsLeft
        {
            get
            {
                return shiftsToWork - shiftsWorked;
            }
        }
        private string currentJob = "";
        public string CurrentJob
        {
            get
            {
                return currentJob;
            }
        }
        private string[] jobsICanDo;
        private int shiftsToWork;
        private int shiftsWorked;
        public bool DoThisJob(string job, int numberOfShifts)
        {
            if (!String.IsNullOrEmpty(currentJob))
                return false;
            for (int i = 0; i < jobsICanDo.Length; i++)
                if (jobsICanDo[i] == job)
                {
                    currentJob = job;
                    this.shiftsToWork = numberOfShifts;
                    shiftsWorked = 0;
                    return true;
                }
            return false;
        }
        public bool DidYouFinish()
        {
            if (String.IsNullOrEmpty(currentJob))
                return false;
            shiftsWorked++;
            if (shiftsWorked > shiftsToWork)
            {
                shiftsWorked = 0;
                shiftsToWork = 0;
                currentJob = "";
                return true;
            }
            else
                return false;
        }
    }
}
