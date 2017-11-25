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
    public partial class apartmentForm : Form
    {
        public apartmentForm()
        {
            InitializeComponent();
        }

        private void apartmentForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            dbconnection sv = new dbconnection();
            sv.thisConnection.Open();

            SqlDataAdapter thisAdapter = new SqlDataAdapter("SELECT * FROM flat", sv.thisConnection);

            SqlCommandBuilder thisBuilder = new SqlCommandBuilder(thisAdapter);

            DataSet thisDataSet = new DataSet();
            thisAdapter.Fill(thisDataSet, "flat");

            DataRow thisRow = thisDataSet.Tables["flat"].NewRow();
            try
            {

                thisRow["flatName"] = textBoxFlatName.Text;
                thisRow["info"] = textBoxInfo.Text;
                thisRow["rent"] = textBoxRent.Text;



                thisDataSet.Tables["flat"].Rows.Add(thisRow);



                thisAdapter.Update(thisDataSet, "flat");
                MessageBox.Show("Submitted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sv.thisConnection.Close();

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
