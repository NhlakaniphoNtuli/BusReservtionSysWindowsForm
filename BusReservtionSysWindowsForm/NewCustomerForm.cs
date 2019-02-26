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
    public partial class NewCustomerForm : Form
    {
        public NewCustomerForm()
        {
            InitializeComponent();
        }
        bool customerPage=false;
        private void NewCustomerForm_Shown(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
            this.MaximizeBox = true;
            tabControl1.SelectedTab = tabPage1;
        }

        private void OneWay_CheckedChanged(object sender, EventArgs e)
        {
            returnDatePick.Enabled = false;
            returnDateLabel.Hide();
            returnDatePick.Hide();
            //returnDatePick.Text = " Not availble";
        }

        private void ReturnTrip_CheckedChanged(object sender, EventArgs e)
        {
            returnDatePick.Enabled = true;
            returnDateLabel.Show();
            returnDatePick.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (customerPage)
            {
                //progressBar1
                tabControl1.SelectedTab = tabPage2;
            }
        }
    }
}
