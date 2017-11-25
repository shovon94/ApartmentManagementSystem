using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApartmentRentManagement
{
    public partial class BillingRecord : Form
    {
        public BillingRecord()
        {
            InitializeComponent();
        }

        private void BillingRecord_Load(object sender, EventArgs e)
        {
            try
            {
                dbconnection sv = new dbconnection();
                sv.thisConnection.Open();

                SqlDataAdapter thisAdapter = new SqlDataAdapter("SELECT * FROM record", sv.thisConnection);

                //SqlCommandBuilder thisBuilder = new SqlCommandBuilder(thisAdapter);
                DataSet ds = new DataSet();
                thisAdapter.Fill(ds,"record");

                dataGridView1.DataSource = ds.Tables[0];

                

                sv.thisConnection.Close();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
