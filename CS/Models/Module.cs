using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS.Models {
  public class Module {
    public string Title{ get; set; }
    public string[] Lessons { get; set; }
    public Module(string title, params string[] lessons) {
      Title = title;
      Lessons = lessons;
    }
  }
}