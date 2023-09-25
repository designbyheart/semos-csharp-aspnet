using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace Ex07 {
  public partial class Form1 : Form {
    public Form1() {
      InitializeComponent();
    }

    private void btnGO_Click(object sender, EventArgs e) {
      SqlConnection conn = new SqlConnection(
        "Data Source=(local);Initial Catalog=MyDB;Integrated Security=True;");
      DataSet ds = new DataSet();
      SqlDataAdapter da = new SqlDataAdapter(tbSQL.Text, conn);
      da.Fill(ds, "tblResult");
      dgvResult.DataSource = ds;
      dgvResult.DataMember = "tblResult";
    }
  }
}
