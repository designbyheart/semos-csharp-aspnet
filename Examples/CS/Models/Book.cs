using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS.Models {
  public class Book {
    public string Category { get; set; }
    public string Download { get; set; }
    public string Purchase { get; set; }
    public string Image { get; set; }
    public string Title { get; set; }
    public string ISBN { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }
    public string Publisher { get; set; }
  }
}