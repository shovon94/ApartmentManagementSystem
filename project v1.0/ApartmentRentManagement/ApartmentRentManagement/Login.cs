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
    public partial class loginFrom : Form
    {
        public loginFrom()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = '\u25CF';
        }

        private void loginFrom_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            /*Home h = new Home();
            h.ShowDialog();
            this.Close();*/

            dbconnection CN = new dbconnection();
            CN.thisConnection.Open();

            SqlCommand thisCommand = new SqlCommand();

            thisCommand.Connection = CN.thisConnection;
            
            thisCommand.CommandText = "SELECT username FROM admin WHERE username='" + textBoxUsername.Text.ToString() + "' AND password='" + textBoxPassword.Text.ToString() + "'";
            SqlDataReader thisReader = thisCommand.ExecuteReader();

            if (thisReader.Read())
            {
               
                Home h = new Home();
                h.ShowDialog();
                this.Close();

            }
            else
            {
                MessageBox.Show("Username or Password incorrect! Please give the Correct Username or Password.","Caution",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
  
        }
    }
}
