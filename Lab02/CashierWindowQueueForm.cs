using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Paala, James P.                    BSIT - 501                         EVENT DRIVEN PTASK

namespace Lab02
{
    public partial class CashierWindowQueueForm : Form
    {
        public CashierWindowQueueForm()
        {
            InitializeComponent();

            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = (1 * 1000);
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if(CashierClass.CashierQueue.Count == 0)
            {
                return;
            }
            DisplayCashierQueue(CashierClass.CashierQueue);
        }


        public void DisplayCashierQueue(IEnumerable CashierList)
        {
            listCashierQueue.Items.Clear();
            foreach (Object obj in CashierList)
            {
                listCashierQueue.Items.Add(obj.ToString());
            }

            // Paala, James P.                    BSIT - 501                         EVENT DRIVEN PTASK
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            btnRefresh.PerformClick();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (CashierClass.CashierQueue.Count == 0)
            {
                MessageBox.Show("No more number in queue");
                return;
            }
            CashierClass.CashierQueue.Dequeue();
            btnRefresh.PerformClick();
        }
    }
}




