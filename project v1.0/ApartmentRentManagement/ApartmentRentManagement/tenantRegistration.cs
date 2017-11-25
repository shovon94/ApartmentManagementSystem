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
    public partial class tenantRegistration : Form
    {
        public tenantRegistration()
        {
            InitializeComponent();
        }

        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfd = new OpenFileDialog();
            openfd.Filter = "Images only. |*.jpg; *.png; *.jpeg; *.gif;";

            DialogResult dr = openfd.ShowDialog();
            pictureBoxTenant.Image = Image.FromFile(openfd.FileName);
        }

        private void radioBtnFemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tenantRegistration_Load(object sender, EventArgs e)
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
                    comboBoxFlatName.Items.Add(DR[0]);

                }

                sv.thisConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                dbconnection sv = new dbconnection();
                sv.thisConnection.Open();

                SqlDataAdapter thisAdapter = new SqlDataAdapter("SELECT * FROM tenant", sv.thisConnection);

                SqlCommandBuilder thisBuilder = new SqlCommandBuilder(thisAdapter);

                DataSet thisDataSet = new DataSet();
                thisAdapter.Fill(thisDataSet, "tenant");

                DataRow thisRow = thisDataSet.Tables["tenant"].NewRow();
            

                thisRow["name"] = textBoxName.Text;

                string value = "";
                bool isChecked = radioBtnMale.Checked;
                if(isChecked )
                  value=radioBtnMale.Text;
                else
                  value=radioBtnFemale.Text;

                thisRow["gender"] = value.ToString();
                thisRow["fatherName"] = textBoxFatherName.Text;
                thisRow["motherName"] = textBoxMotherName.Text;
                thisRow["phoneno"] = textBoxPhoneNo.Text;
                thisRow["email"] = textBoxEmail.Text;
                thisRow["balance"] = 0;
                thisRow["occupation"] = textBoxOccupation.Text;
                thisRow["country"] = textBoxCountry.Text;
                thisRow["address"] = textBoxAddress.Text;
                thisRow["rentDate"] = dateOfRent.Text;

                Image img = pictureBoxTenant.Image;
                byte[] arr;
                ImageConverter converter = new ImageConverter();
                arr = (byte[])converter.ConvertTo(img, typeof(byte[]));

                thisRow["photo"] = arr;

                Image img2 = pictureBoxNID.Image;
                byte[] arr2;
                ImageConverter converter2 = new ImageConverter();
                arr2 = (byte[])converter.ConvertTo(img2, typeof(byte[]));

                thisRow["nid"] = arr2;
                thisRow["nidno"] = textBoxNID.Text;


                thisDataSet.Tables["tenant"].Rows.Add(thisRow);

                thisAdapter.Update(thisDataSet, "tenant");
                sv.thisConnection.Close();

                dbconnection sv1 = new dbconnection();
                sv1.thisConnection.Open();

                string id = "";
                string Sql = "select tenantId from tenant where name='" + textBoxName.Text.ToString() + "'";

                SqlCommand cmd = new SqlCommand(Sql, sv1.thisConnection);
                SqlDataReader DR = cmd.ExecuteReader();

                while (DR.Read())
                {
                    id = (DR["tenantId"].ToString());
                }

                sv1.thisConnection.Close();


                dbconnection sv2 = new dbconnection();
                sv2.thisConnection.Open();
                SqlCommand thisCommand = sv2.thisConnection.CreateCommand();

                thisCommand.CommandText =
                    "update flat set tenantId = '" + id + "' where flatName= '" + comboBoxFlatName.Text + "'";

                thisCommand.Connection = sv2.thisConnection;
                thisCommand.CommandType = CommandType.Text;

                thisCommand.ExecuteNonQuery();
                

                sv2.thisConnection.Close();

                MessageBox.Show("Submitted");
                
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnNIDImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfd = new OpenFileDialog();
            openfd.Filter = "Images only. |*.jpg; *.png; *.jpeg; *.gif;";

            DialogResult dr = openfd.ShowDialog();
            pictureBoxNID.Image = Image.FromFile(openfd.FileName);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
