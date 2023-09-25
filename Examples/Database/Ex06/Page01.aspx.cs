using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;

namespace Ex06 {
  public partial class Page01 : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
      SqlConnection conn = new SqlConnection("" +
        "Data Source=(local);Initial Catalog=MyDB;Integrated Security=True;");
      SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM State", conn);
      DataSet ds = new DataSet();
      da.Fill(ds, "TblState");

      //Binding Method
      gvStates.DataSource = ds;
      gvStates.DataMember = "TblState";
      gvStates.DataBind();

      //Buiding Method
      lbLocalName.Items.Clear();
      foreach(DataRow dr in ds.Tables["TblState"].Rows) {
        lbLocalName.Items.Add(dr["LocalName"].ToString());
      }
    }
  }
}