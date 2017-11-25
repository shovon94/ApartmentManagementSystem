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
    public partial class billForm : Form
    {
        public billForm()
        {
            InitializeComponent();
        }

        private void billForm_Load(object sender, EventArgs e)
        {
            textBoxYear.Text = DateTime.Now.ToString("yyyy");
            try
            {

                dbconnection sv = new dbconnection();
                sv.thisConnection.Open();

                string Sql = "select flatName from flat";

                SqlCommand cmd = new SqlCommand(Sql, sv.thisConnection);
                SqlDataReader DR = cmd.ExecuteReader();

                while (DR.Read())
                {
                    comboBoxFlatName.Items.Add(DR[0]);

                }

                sv.thisConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxFlatName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dbconnection sv = new dbconnection();
                sv.thisConnection.Open();

                string Sql = "select * from flat f,tenant t,charges c where f.flatName='" + comboBoxFlatName.Text.ToString() + "' and f.tenantID = t.tenantId";

                SqlCommand cmd = new SqlCommand(Sql, sv.thisConnection);
                SqlDataReader DR = cmd.ExecuteReader();

                while (DR.Read())
                {
                    textBoxTenantName.Text = (DR["name"].ToString());
                    textBoxRent.Text = (DR["rent"].ToString());
                    textBoxBalance.Text = (DR["balance"].ToString());
                    textBoxGasBill.Text = (DR["gas"].ToString());
                    textBoxWaterBill.Text = (DR["water"].ToString());
                    textBoxUtilityBill.Text = (DR["utility"].ToString());
                }

                sv.thisConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!(textBoxBalance.Text.Equals("") && textBoxRent.Text.Equals("") && textBoxGasBill.Text.Equals("") && textBoxWaterBill.Text.Equals("") && textBoxUtilityBill.Text.Equals("") && textBoxElectricityBill.Text.Equals("")))
            {
                int rent = Convert.ToInt32(textBoxRent.Text.ToString());
                int gas = Convert.ToInt32(textBoxGasBill.Text.ToString());
                int water = Convert.ToInt32(textBoxWaterBill.Text.ToString());
                int utility = Convert.ToInt32(textBoxUtilityBill.Text.ToString());
                int electricity = Convert.ToInt32(textBoxElectricityBill.Text.ToString());
                int balance = Convert.ToInt32(textBoxBalance.Text.ToString());

                textBoxTotalBill.Text = (rent+gas+water+electricity+utility+balance).ToString();
            }
            else
            {
                MessageBox.Show("Fill all the textbox");

            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            dbconnection sv = new dbconnection();
            sv.thisConnection.Open();

            SqlDataAdapter thisAdapter = new SqlDataAdapter("SELECT * FROM record", sv.thisConnection);

            SqlCommandBuilder thisBuilder = new SqlCommandBuilder(thisAdapter);

            DataSet thisDataSet = new DataSet();
            thisAdapter.Fill(thisDataSet, "record");

            DataRow thisRow = thisDataSet.Tables["record"].NewRow();
            try
            {

                thisRow["recordId"] = textBoxBillNo.Text;
                thisRow["month"] = comboBoxMonth.Text;
                thisRow["year"] = textBoxYear.Text;
                thisRow["flatName"] = comboBoxFlatName.Text;
                thisRow["tenantName"] = textBoxTenantName.Text;
                thisRow["remarks"] = textBoxRemarks.Text;
                thisRow["totalBill"] = textBoxTotalBill.Text;
                thisRow["electricityBill"] = textBoxElectricityBill.Text;
                thisRow["date"] = date.Text;


                thisDataSet.Tables["record"].Rows.Add(thisRow);



                thisAdapter.Update(thisDataSet, "record");
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
