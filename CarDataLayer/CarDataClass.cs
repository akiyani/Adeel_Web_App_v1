using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration; 

namespace CarDataLayer
//get car data from the database
{
    public class CarDataClass
    {
        //method name should be simple and easy to understand. Line 16 Method Signature
        public static DataSet GetCarDataUsingDbWithConfig()
        {
            //Establish sql connection
            //NOTE: SqlConnection, SqlCommand, SqlDataReader are all objects... 
            //...available in the System.Data library
            SqlConnection cnn;
            string sql = null;
            SqlCommand command;
            SqlDataReader dataReader;

            DataTable dt = new DataTable();
            DataSet dsCarDataReport = new DataSet();

            var cs = ConfigurationManager.ConnectionStrings["CarDb_PROD"].ConnectionString; 
            cnn = new SqlConnection(cs);
            sql = "select * from CarModelTable";

            //open the connection
            cnn.Open();
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();
            dt.Load(dataReader);
            dsCarDataReport.Tables.Add(dt);
            dataReader.Close();
            command.Dispose();
            cnn.Close();

            return dsCarDataReport;

        }
    }
}
