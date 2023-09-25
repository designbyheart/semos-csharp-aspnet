using System;

using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace Ex04 {
  internal class Program {
    static void Main(string[] args) {
      SqlConnection conn = new SqlConnection(
        "Data Source=(local);Initial Catalog=MyDB;Integrated Security=True;");
      SqlCommand cmd = new SqlCommand(
        "SELECT c.Name, Count(s.ID) [No of States] FROM State s " +
        "JOIN Country c ON s.Country = c.Code " +
        "WHERE s.Name<>'Selangor' " +
        "GROUP BY c.Name " +
        "HAVING COUNT(s.ID) > @MinStates " +
        "ORDER BY COUNT(s.ID) DESC"
        ,conn);
      Console.Write("Min States?>>");
      int minStates = int.Parse(Console.ReadLine());
      cmd.Parameters.Add("@MinStates", SqlDbType.Int);
      cmd.Parameters["@MinStates"].Direction = ParameterDirection.Input;
      cmd.Parameters["@MinStates"].Value = minStates;

      try {
        conn.Open();
        SqlDataReader dr = cmd.ExecuteReader();
        while (dr.Read()) {
          Console.WriteLine("{0,-20} {1}", dr["Name"], dr["No of States"]);
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
