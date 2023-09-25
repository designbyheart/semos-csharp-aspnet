using System;

using System.Data;
using System.Data.SqlClient;

namespace Ex05 {
  internal class Program {
    static void Main(string[] args) {
      SqlConnection conn = new SqlConnection(
        "Data Source=(local);Initial Catalog=MyDB;Integrated Security=True;");
      SqlCommand cmd = new SqlCommand("StatesByCountryName", conn);
      cmd.CommandType = CommandType.StoredProcedure;
      cmd.Parameters.Add("@CountryName", SqlDbType.VarChar,128);
      cmd.Parameters["@CountryName"].Direction = ParameterDirection.Input;
      cmd.Parameters["@CountryName"].Value = "Japan";

      try {
        conn.Open();
        SqlDataReader dr = cmd.ExecuteReader();
        while (dr.Read()) {
          Console.WriteLine("{0,4}:{1}", dr["ID"], dr["Name"]);
        }
        dr.Close();
      } catch (SqlException ex) {
        Console.WriteLine("Code:{0}\nMessage:{1}", ex.Number, ex.Message);
      } finally {
        if ((conn != null) && (conn.State == ConnectionState.Open)) {
          conn.Close();
        }
      }
      Console.ReadKey();

    }
  }
}
