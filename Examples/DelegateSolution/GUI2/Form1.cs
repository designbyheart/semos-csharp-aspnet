using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI2 {
  public partial class Form1 : Form {
    public Form1() {
      InitializeComponent();
    }

    private void miExit_Click(object sender, EventArgs e) {
      if (MessageBox.Show("Are you sure?","Exit Application", MessageBoxButtons.YesNo) == DialogResult.Yes) {
        Application.Exit();
      }
    }

    private Color childColor = Color.DarkGray;
    private void miOpen_Click(object sender, EventArgs e) {
      Child child = new Child(childColor);
      child.MdiParent = this;
      child.Show();
      miClose.Enabled = true;
      tsbClose.Enabled = true;
    }

    private void ChangeChildColor(object sender, EventArgs e) {
      ToolStripMenuItem mi = sender as ToolStripMenuItem;
      childColor = Color.FromName(mi.Text.Replace("&",""));
    }

    private void miColorCustom_Click(object sender, EventArgs e) {
      colorDialog1.Color = childColor;
      if (colorDialog1.ShowDialog() == DialogResult.OK) {
        childColor = colorDialog1.Color;
      }
    }

    private void miClose_Click(object sender, EventArgs e) {
      ActiveMdiChild.Close();
      miClose.Enabled = ActiveMdiChild!=null;
      tsbClose.Enabled = miClose.Enabled;
    }

    private void tsbOpen_Click(object sender, EventArgs e) {
      miOpen.PerformClick();
    }

    private void tsbClose_Click(object sender, EventArgs e) {
      miClose.PerformClick();
    }

    private void timer1_Tick(object sender, EventArgs e) {
      tsslDateTime.Text = DateTime.Now.ToString("dd/MMM/yyyy hh:mm:ss");
    }
  }
}
