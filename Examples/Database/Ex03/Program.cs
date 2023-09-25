using System;

using System.Data;
using System.Data.SqlClient;

namespace Ex03 {
  internal class Program {
    static void Main(string[] args) {
      SqlConnection conn = new SqlConnection(
        "Data Source=(local);Initial Catalog=MyDB;Integrated Security=True;");
      SqlCommand cmd = new SqlCommand(
        "INSERT INTO [Member] VALUES('faris','faris123',NULL)", conn);
      try {
        conn.Open();
        int n = cmd.ExecuteNonQuery();//For DML (Insert, Update, Delete)
        Console.WriteLine("{0} row affected....",n);
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
