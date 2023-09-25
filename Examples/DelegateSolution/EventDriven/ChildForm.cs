using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventDriven {
  public partial class ChildForm : Form {
    public ChildForm() {
      InitializeComponent();
    }
    public ChildForm(Color color):this() {
      BackColor = color;
    }
  }
}
