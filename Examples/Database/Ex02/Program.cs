using System;

using System.Data;
using System.Data.SqlClient;

namespace Ex02 {
  internal class Program {
    static void Main(string[] args) {
      SqlConnection conn = new SqlConnection(
        "Data Source=(local);Initial Catalog=MyDB;Integrated Security=True;");
      SqlCommand cmd = new SqlCommand("SELECT * FROM State", conn);
      try {
        conn.Open();
        SqlDataReader dr = cmd.ExecuteReader();
        while(dr.Read()) {
          Console.WriteLine(dr["Name"]);
        }
        dr.Close();
			} catch (SqlException ex) {
        Console.WriteLine("Code:{0}\nMessage:{1}",ex.Number,ex.Message);
			} finally {
        if ((conn!=null) && (conn.State == ConnectionState.Open)) {
          conn.Close();
        }
      }
      Console.ReadKey();
    }
  }
}
