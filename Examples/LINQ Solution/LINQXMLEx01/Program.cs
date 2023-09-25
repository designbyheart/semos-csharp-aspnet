using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Xml.Linq;

namespace LINQXMLEx01 {
  class Program {
    static void Main(string[] args) {
      XElement xelement = XElement.Load(@"..\..\Employees.xml");
      IEnumerable<XElement> employees = xelement.Elements();
      Console.WriteLine("Display entire XML Data:");
      foreach (var employee in employees) Console.WriteLine(employee);

      Console.WriteLine("\nList of all Employee Names:");
      foreach (var employee in employees) Console.WriteLine(employee.Element("Name").Value);

      Console.WriteLine("\nList of all Employee Names along with their ID:");
      foreach (var employee in employees) {
        Console.WriteLine("{0} has Employee ID {1}",
            employee.Element("Name").Value,
            employee.Element("EmpId").Value);
      }

      Console.WriteLine("\nAccess Specific Element having a Specific Attribute using LINQ to XML:");
      //List HomePhone Nos.
      var homePhone = from phoneno in xelement.Elements("Employee")
                      where (string)phoneno.Element("Phone").Attribute("Type") == "Home"
                      select phoneno;
      foreach (XElement xEle in homePhone) Console.WriteLine(xEle.Element("Phone").Value);

      Console.WriteLine("\nFind an Element within another Element using LINQ to XML:");
      //Details of Employees living in Alta City
      var addresses = from address in xelement.Elements("Employee")
                      where (string)address.Element("Address").Element("City") == "Alta"
                      select address;
      foreach (XElement xEle in addresses) Console.WriteLine(xEle);


      Console.WriteLine("\nFind Nested Elements (using Descendants Axis) using LINQ to XML:");
      //List of all Zip Codes
      foreach (XElement xEle in xelement.Descendants("Zip")) Console.WriteLine((string)xEle);


      Console.WriteLine("\napply Sorting on Elements using LINQ to XML:");
      IEnumerable<string> codes = from code in xelement.Elements("Employee")
                                  let zip = (string)code.Element("Address").Element("Zip")
                                  orderby zip
                                  select zip;
      //List and Sort all Zip Codes
      foreach (string zp in codes) Console.WriteLine(zp);

      Console.ReadKey();
    }
  }
}
