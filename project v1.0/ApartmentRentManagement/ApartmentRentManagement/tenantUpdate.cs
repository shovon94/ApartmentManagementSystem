using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApartmentRentManagement
{
    public partial class tenantUpdate : Form
    {
        public tenantUpdate()
        {
            InitializeComponent();
        }

        private void tenantUpdate_Load(object sender, EventArgs e)
        {
            try
            {

                dbconnection sv = new dbconnection();
                sv.thisConnection.Open();

                string Sql = "select name from tenant";

                SqlCommand cmd = new SqlCommand(Sql, sv.thisConnection);
                SqlDataReader DR = cmd.ExecuteReader();

                while (DR.Read())
                {
                    comboBoxTenantName.Items.Add(DR[0]);

                }

                sv.thisConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxTenantName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dbconnection sv = new dbconnection();
                sv.thisConnection.Open();

                string Sql = "select * from tenant where name='" + comboBoxTenantName.Text.ToString() + "'";

                SqlCommand cmd = new SqlCommand(Sql, sv.thisConnection);
                SqlDataReader DR = cmd.ExecuteReader();
                while (DR.Read())
                {
                    string gender = (DR["gender"].ToString());
                    if(radioBtnMale.Text.Equals(gender))
                    {
                        radioBtnMale.Checked = true;
                        radioBtnFemale.Checked = false;
                    }
                    else
                    {
                        radioBtnFemale.Checked = true;
                        radioBtnMale.Checked = false;
                    }

                    textBoxFatherName.Text = (DR["fatherName"].ToString());
                    textBoxMotherName.Text = (DR["motherName"].ToString());
                    textBoxOccupation.Text = (DR["occupation"].ToString());
                    textBoxCountry.Text = (DR["country"].ToString());
                    textBoxPhoneNo.Text = (DR["phoneNo"].ToString());
                    textBoxEmail.Text = (DR["email"].ToString());
                    textBoxAddress.Text = (DR["address"].ToString());
                    
                    //date
                    dateOfRent.Text = (DR["rentDate"].ToString());
                }
                sv.thisConnection.Close();

                //for image retrieve
                dbconnection svv = new dbconnection();
                svv.thisConnection.Open();

                SqlCommand cmdSelect = new SqlCommand("select photo from tenant where name='" + comboBoxTenantName.Text.ToString() + "'", svv.thisConnection);

                byte[] barrImg=(byte[])cmdSelect.ExecuteScalar();
                string strfn=Convert.ToString(DateTime.Now.ToFileTime());
                FileStream fs=new FileStream(strfn,FileMode.CreateNew,FileAccess.Write);
                fs.Write(barrImg,0,barrImg.Length);
                fs.Flush();
                fs.Close();

                pictureBoxTenant.Image=Image.FromFile(strfn);

                SqlCommand cmdSelect2 = new SqlCommand("select nid from tenant where name='" + comboBoxTenantName.Text.ToString() + "'", svv.thisConnection);

                byte[] barrImg2 = (byte[])cmdSelect2.ExecuteScalar();
                string strfn2 = Convert.ToString(DateTime.Now.ToFileTime());
                FileStream fs2 = new FileStream(strfn2, FileMode.CreateNew, FileAccess.Write);
                fs2.Write(barrImg2, 0, barrImg2.Length);
                fs2.Flush();
                fs2.Close();

                pictureBoxNID.Image = Image.FromFile(strfn2);

                svv.thisConnection.Close();

                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfd = new OpenFileDialog();
            openfd.Filter = "Images only. |*.jpg; *.png; *.jpeg; *.gif;";

            DialogResult dr = openfd.ShowDialog();
            pictureBoxTenant.Image = Image.FromFile(openfd.FileName);
        }

        private void btnNIDImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfd = new OpenFileDialog();
            openfd.Filter = "Images only. |*.jpg; *.png; *.jpeg; *.gif;";

            DialogResult dr = openfd.ShowDialog();
            pictureBoxNID.Image = Image.FromFile(openfd.FileName);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                dbconnection sv = new dbconnection();
                sv.thisConnection.Open();
                SqlCommand thisCommand = sv.thisConnection.CreateCommand();

                string gender = "";
                bool isChecked = radioBtnMale.Checked;
                if(isChecked)
                {
                    gender = radioBtnMale.Text;
                }
                else
                {
                    gender = radioBtnFemale.Text;
                }

                Image img = pictureBoxTenant.Image;
                byte[] arr;
                ImageConverter converter = new ImageConverter();
                arr = (byte[])converter.ConvertTo(img, typeof(byte[]));

                Image img2 = pictureBoxNID.Image;
                byte[] arr2;
                ImageConverter converter2 = new ImageConverter();
                arr2 = (byte[])converter.ConvertTo(img2, typeof(byte[]));

                /*thisCommand.CommandText =
                    "update tenant set gender = '" + gender + "',fatherName = '" + textBoxFatherName.Text + "' ,motherName = '" + textBoxMotherName.Text + "',occupation = '" + textBoxOccupation.Text + "' ,country = '" + textBoxCountry.Text + "' ,phoneNo = '" + textBoxPhoneNo.Text + "' ,email = '" + textBoxEmail.Text + "' ,address = '" + textBoxAddress.Text + "'  where name= '" + comboBoxTenantName.Text + "'";
                */
                thisCommand.CommandText =
                    "update tenant set  rentDate = '" + dateOfRent.Text.ToString() + "' where name= '" + comboBoxTenantName.Text + "'";

                // , rentDate = '" + dateOfRent.Text + "'
                //,photo = '" + arr + "' ,nid = '" + arr2 + "'

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
                    "delete tenant where name= '" + comboBoxTenantName.Text + "'";

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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
