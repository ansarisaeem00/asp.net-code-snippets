using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace EndToEnd.Models
{
    public class SelectModel
    {
    }

  /*  public DataSet GetAllAuthors()
    {
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-AH34LDI;DataBase=DEMODB.MDF");
        SqlCommand cmd = new SqlCommand("Select AuthorId,Fname,Lname From Authors", cn);
        DataSet ds = new DataSet();
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(ds);
        return ds;
    }*/
}