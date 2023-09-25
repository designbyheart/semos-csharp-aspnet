using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS.Models {
  public class Course {
    public string Code { get; set; }
    public string Title { get; set; }
    public Module[] Modules { get; set; }
    public Course(string code, string title, params Module[] modules) {
      Code = code;
      Title = title;
      Modules = modules;
    }
    public Module this[string title] {
      get {
        return Modules.FirstOrDefault(m => m.Title == title);
      }
    }
  }
}