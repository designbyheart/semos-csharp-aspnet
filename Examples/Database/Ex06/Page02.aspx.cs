using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;

namespace Ex06 {
  public partial class Page02 : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
      DataSet ds = new DataSet();
      ds.ReadXml(Server.MapPath(@"XML\MU.xml"));
      gvXML.DataSource = ds.Tables[0];
      gvXML.DataBind();
    }
  }
}