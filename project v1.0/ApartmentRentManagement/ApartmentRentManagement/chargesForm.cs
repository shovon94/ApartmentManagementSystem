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
    public partial class chargesForm : Form
    {
        public chargesForm()
        {
            InitializeComponent();
        }

        private void chargesForm_Load(object sender, EventArgs e)
        {
            try
            {

                dbconnection sv = new dbconnection();
                sv.thisConnection.Open();

                string Sql = "select * from charges where no=1";

                SqlCommand cmd = new SqlCommand(Sql, sv.thisConnection);
                SqlDataReader DR = cmd.ExecuteReader();

                while (DR.Read())
                {
                    textBoxWaterBill.Text = (DR["water"].ToString());
                    textBoxGasBill.Text = (DR["gas"].ToString());
                    textBoxUtility.Text = (DR["utility"].ToString());

                }

                sv.thisConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                dbconnection sv = new dbconnection();
                sv.thisConnection.Open();
                SqlCommand thisCommand = sv.thisConnection.CreateCommand();


                thisCommand.CommandText =
                    "update charges set gas = '" + textBoxGasBill.Text + "' , water = '" + textBoxWaterBill.Text + "', utility = '" + textBoxUtility.Text + "' where no = 1";

                thisCommand.Connection = sv.thisConnection;
                thisCommand.CommandType = CommandType.Text;
                //For Insert Data Into Sql//

                thisCommand.ExecuteNonQuery();
                MessageBox.Show("Updated");

                sv.thisConnection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
