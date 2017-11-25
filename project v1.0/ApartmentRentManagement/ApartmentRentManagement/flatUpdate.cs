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
    public partial class flatUpdate : Form
    {
        public flatUpdate()
        {
            InitializeComponent();
        }

        private void flatUpdate_Load(object sender, EventArgs e)
        {
            try
            {
                
                dbconnection sv = new dbconnection();
                sv.thisConnection.Open();
                 
                string Sql = "select flatName from flat";
               
                SqlCommand cmd = new SqlCommand(Sql, sv.thisConnection);
                SqlDataReader DR = cmd.ExecuteReader();

                while (DR.Read())
                {
                    comboBox1.Items.Add(DR[0]);

                }

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dbconnection sv = new dbconnection();
                sv.thisConnection.Open();

                string Sql = "select * from flat where flatName='"+ comboBox1.Text.ToString() +"'";

                SqlCommand cmd = new SqlCommand(Sql, sv.thisConnection);
                SqlDataReader DR = cmd.ExecuteReader();

                while (DR.Read())
                {
                    textBoxInfo.Text = (DR["info"].ToString());
                    textBoxRent.Text = (DR["rent"].ToString());
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
                    "update flat set info = '" + textBoxInfo.Text + "' , rent = '" + textBoxRent.Text + "' where flatName= '" + comboBox1.Text + "'";

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

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                dbconnection con = new dbconnection();
                con.thisConnection.Open();

                SqlCommand thisCommand1 = con.thisConnection.CreateCommand();

                thisCommand1.CommandText =
                    "delete flat where flatName= '" + comboBox1.Text + "'";

                thisCommand1.Connection = con.thisConnection;
                thisCommand1.CommandType = CommandType.Text;
                //For Insert Data Into Sql//

                thisCommand1.ExecuteNonQuery();
                MessageBox.Show("delete successfully");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
