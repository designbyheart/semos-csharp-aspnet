using System;

using System.Data;
using System.Data.SqlClient;

namespace Ex01 {
  internal class Program {
    static void Main(string[] args) {
      SqlConnection conn = new SqlConnection(
        "Data Source=(local);Initial Catalog=MyDB;Integrated Security=True;");
      SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM State", conn);
      DataSet ds = new DataSet();
      da.Fill(ds,"TblState");
      foreach(DataRow dr in ds.Tables["TblState"].Rows) {
        Console.WriteLine(dr["Name"]);
      }
      Console.ReadKey();
    }
  }
}
