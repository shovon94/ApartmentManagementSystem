using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentRentManagement
{
    class dbconnection
    {
        public SqlConnection thisConnection = new SqlConnection("Data Source=DESKTOP-4QMN2RR\\SQLEXPRESS;Initial Catalog=ApartmentManagement;Integrated Security=True");
    }
}
