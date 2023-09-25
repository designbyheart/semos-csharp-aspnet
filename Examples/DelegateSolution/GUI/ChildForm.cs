using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI {
  public partial class ChildForm : Form {
    public ChildForm() {
      InitializeComponent();
    }
    public ChildForm(string title, Color color):base() {
      Text = title;
      BackColor = color;
    }

    private void ChildForm_Load(object sender, EventArgs e) {

    }
  }
}
