using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//libraries nee ot talk to database
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// This class will connect to the database
/// It will have methods to retrieve the services
/// It will also retrieve all the grants for that service
/// John Voorhess 4/12/2016
/// </summary>
public class DataClass
{
    SqlConnection connect;
    public DataClass()
    {
        connect = new SqlConnection(ConfigurationManager.ConnectionStrings["CommunityAssistConnectionString"].ToString());
    }//end constructor

    public DataTable GetServices()
    {
        DataTable tbl = null;

        string sql = "Select GrantTypeKey, GrantTypeName from GrantType";
        SqlCommand cmd = new SqlCommand(sql, connect);
        SqlDataReader reader = null;
        tbl = new DataTable();
    

        connect.Open();
        reader = cmd.ExecuteReader();
        tbl.Load(reader);
        reader.Close();
        connect.Close();


        return tbl;
    }

}//end class
