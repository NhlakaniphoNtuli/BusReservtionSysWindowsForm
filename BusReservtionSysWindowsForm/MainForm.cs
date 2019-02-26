using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusReservtionSysWindowsForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void bntNewCustomer_Click(object sender, EventArgs e)
        {
            //var myNewCustomerForm = new NewCustomerForm();
            //myNewCustomerForm.Show();
            //this.Hide();
        }

        private void picLogo_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            bntNewCustomer.Hide();
            btnCancelReservation.Hide();
            btnNewBus.Hide();
            btnReservationReport.Hide();
            btnReserve.Hide();
            

            //this.WindowState = FormWindowState.Maximized;

            picAgent.Image = Image.FromFile("../../images/NIPHO.png");   //Load agent image
            lblAgentUsername.Text = "Nipho Ntuli";   //Load agent username
            lblAgentId.Text = "63559TR";   //Load agent ID
        }

        private void picManageTicket_Click(object sender, EventArgs e)
        {
            var myNewCustomerForm = new NewCustomerForm();
            myNewCustomerForm.Show();
            this.Hide();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //this.Hide();
            //Login login = new Login();
            //login.Show();
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
