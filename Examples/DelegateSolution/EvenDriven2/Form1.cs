using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvenDriven2 {
  public partial class Form1 : Form {
    public Form1() {
      InitializeComponent();
    }

    private void SendMsgToLabel1(object sender, EventArgs e) {
      Button btn = sender as Button;
      label1.Text = "Greeting from " + btn.Name;
    }

    private void SendMsgToLabel2(object sender, EventArgs e) {
      Button btn = sender as Button;
      label2.Text = "Greeting from " + btn.Name;
    }

    private void Form1_Load(object sender, EventArgs e) {
      button2.Click += new EventHandler(SendMsgToLabel2);
    }
  }
}
