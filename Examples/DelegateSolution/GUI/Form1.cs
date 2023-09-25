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
  public partial class Form1 : Form {
    public Form1() {
      InitializeComponent();
    }

    private void miExit_Click(object sender, EventArgs e) {
      if(MessageBox.Show("Are you sure?","Exit Application",
          MessageBoxButtons.YesNo) == DialogResult.Yes) {
        Application.Exit();
      }
    }

    private void ChangeBackgroundColor(object sender, EventArgs e) {
      ToolStripMenuItem mi = sender as ToolStripMenuItem;
      BackColor = Color.FromName(mi.Text.Replace("&",""));
    }

    private void miColorCustom_Click(object sender, EventArgs e) {
      colorDialog1.Color = BackColor;
      if (colorDialog1.ShowDialog() == DialogResult.OK) {
        BackColor = colorDialog1.Color;
      }
    }

    private void miOpen_Click(object sender, EventArgs e) {
      ChildForm cf = new ChildForm("I am Child Form", BackColor);
      cf.MdiParent = this;
      cf.Show();
      miClose.Enabled = true;
    }

    private void miClose_Click(object sender, EventArgs e) {
      ActiveMdiChild.Close();
      miClose.Enabled = (ActiveMdiChild!=null);
    }

    private void tsbOpen_Click(object sender, EventArgs e) {
      miOpen.PerformClick();
    }
  }
}
