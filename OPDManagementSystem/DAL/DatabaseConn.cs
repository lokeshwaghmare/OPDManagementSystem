using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace OPDManagementSystem.DAL
{

    public class DatabaseConn
    {
        private string dbConnection;
        private SqlDataAdapter dataAdapter;
        private DataSet dataSet;

        public DatabaseConn()
        {
            dbConnection = ConfigurationManager.ConnectionStrings["databaseConnection"].ConnectionString;
        }

        public DataSet getDoctorsList()
        {
            string cmdString = "SELECT * FROM Doctors";
            dataAdapter = new SqlDataAdapter(cmdString, dbConnection);
            dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataAdapter.Dispose();
            return dataSet;
        }
    }
}
