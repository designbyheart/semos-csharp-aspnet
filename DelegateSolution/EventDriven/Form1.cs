using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EventDriven {
  public partial class Form1 : Form {
    public Form1() {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e) {
    }

    private void miExit_Click(object sender, EventArgs e) {
      if (MessageBox.Show("Are your sure?","End Application", MessageBoxButtons.YesNo) == DialogResult.Yes) {
        Application.Exit();
      }
    }

    Color childColor = Color.White;
    private void miOpen_Click(object sender, EventArgs e) {
      ChildForm child = new ChildForm(childColor);
      child.MdiParent = this;
      child.Show();
    }

    private void ChangeChildColor(object sender, EventArgs e) {
      ToolStripMenuItem mi = sender as ToolStripMenuItem;
      string sColor = mi.Text.Replace("&", "");
      childColor = Color.FromName(sColor);
    }

    private void miColorCustom_Click(object sender, EventArgs e) {
      if(colorDialog1.ShowDialog() == DialogResult.OK) {
        childColor = colorDialog1.Color;
      }
    }

    private void tsbOpen_Click(object sender, EventArgs e) {
      miOpen.PerformClick();
    }

    private void timer1_Tick(object sender, EventArgs e) {
      slDateTime.Text = DateTime.Now.ToString("dd/MMM/yyyy hh:mm:ss");
    }
  }
}
