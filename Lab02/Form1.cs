
// Paala, James P.                    BSIT - 501                         EVENT DRIVEN PTASK
namespace Lab02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = (1 * 1000);
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();
        }

        CashierClass cashier = new CashierClass();

        private void btnCashier_Click(object sender, EventArgs e)
        {
            CashierWindowQueueForm cashier = new CashierWindowQueueForm();
            cashier.ShowDialog();
        }

        // Paala, James P.                    BSIT - 501                         EVENT DRIVEN PTASK

        private void button1_Click(object sender, EventArgs e)
        {
            CashierClass.getNumberInQueue = cashier.CashierGeneratedNumber("P - ");
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);
        }

        private void lblQueue_Click(object sender, EventArgs e)
        {
            CustomerView customer = new CustomerView();
            customer.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblQueue.Text = cashier.GetCurrentNumber();
        }
    }
}