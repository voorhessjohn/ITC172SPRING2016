using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//libraries need to talk to database
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

    public DataTable GetAuthors()
    {
        DataTable tbl = null;

        string sql = "SELECT authorkey, authorname FROM Author";
        SqlCommand cmd = new SqlCommand(sql, connect);
    
        tbl = ReadData(cmd);
    
        return tbl;
    }

    public DataTable GetBooks(int AuthorKey)
    {
        DataTable tbl = null;
        string sql = "SELECT * FROM book INNER JOIN authorbook ON book.bookkey= authorbook.bookkey WHERE authorkey = @authorkey";

        SqlCommand cmd = new SqlCommand(sql, connect);
        cmd.Parameters.AddWithValue("@AuthorKey", AuthorKey);

        tbl = ReadData(cmd);

        return tbl;
    }

    private DataTable ReadData(SqlCommand cmd)
    {
        SqlDataReader reader = null;
        DataTable tbl = new DataTable();


        connect.Open();
        reader = cmd.ExecuteReader();
        tbl.Load(reader);
        reader.Close();
        connect.Close();


        return tbl;
    }

}//end class
