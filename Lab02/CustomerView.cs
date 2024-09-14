
// Paala, James P.                    BSIT - 501                         EVENT DRIVEN PTASK
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class CustomerView : Form
    {
        public CustomerView()
        {
            InitializeComponent();
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = (1 * 1000);
            timer.Tick += new EventHandler(timer2_Tick);
            timer.Start();
        }

        // Paala, James P.                    BSIT - 501                         EVENT DRIVEN PTASK

        private void lblQueue_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lblServing.Text = CashierClass.CashierQueue.First().ToString();
        }
    }
}
