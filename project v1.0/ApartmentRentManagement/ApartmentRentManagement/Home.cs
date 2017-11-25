using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApartmentRentManagement
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        
        private void rentBillsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            billForm b = new billForm();
            b.ShowDialog();
        }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tenantRegistration t = new tenantRegistration();
            t.ShowDialog();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            apartmentForm a = new apartmentForm();
            a.ShowDialog();
            
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Home h = new Home();
            //h.ShowDialog();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flatUpdate f = new flatUpdate();
            f.ShowDialog();
        }

        private void updateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tenantUpdate t = new tenantUpdate();
            t.ShowDialog();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //Application.Exit();
            this.Close();
            loginFrom t = new loginFrom();
            t.ShowDialog();

            
        }

        private void allTenantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tenantsRecord t = new tenantsRecord();
            t.ShowDialog();

        }

        private void billingHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BillingRecord t = new BillingRecord();
            t.ShowDialog();
        }

        private void chargesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            chargesForm t = new chargesForm();
            t.ShowDialog();
        }

        
    }
}
