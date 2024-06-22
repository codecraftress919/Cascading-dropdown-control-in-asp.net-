using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
namespace WebApplication1
{
    public class DataAccessLayer
    {
        string constr;
        SqlConnection mydbcon;
        SqlDataAdapter da;
        DataSet ds;
        public DataAccessLayer()
        {
            constr = System.Configuration.ConfigurationManager.ConnectionStrings["cs"].ToString();
        }
        protected SqlConnection OpenDBcon()
        {
            mydbcon = new SqlConnection(constr);
            mydbcon.Open();
            return mydbcon;
        }
        public DataSet FillDS(string query)
        {
            da = new SqlDataAdapter(query, OpenDBcon());
            ds= new DataSet();
            da.Fill(ds);
            return ds;
        }
        public void FillDD(DropDownList ddl, string query)
        {
            ddl.DataSource = FillDS(query).Tables[0];
            ddl.DataValueField = ds.Tables[0].Columns[0].ToString();
            ddl.DataTextField = ds.Tables[0].Columns[1].ToString();
            
            ddl.DataBind();
            ddl.Items.Insert(0, new ListItem("<---select--->", "0"));

        }


    }

   
}