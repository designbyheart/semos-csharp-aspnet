namespace GUI2 {
  partial class Form1 {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.miOpen = new System.Windows.Forms.ToolStripMenuItem();
      this.miClose = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.miExit = new System.Windows.Forms.ToolStripMenuItem();
      this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.miColorRed = new System.Windows.Forms.ToolStripMenuItem();
      this.miColorGreen = new System.Windows.Forms.ToolStripMenuItem();
      this.miColorBlue = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.miColorCustom = new System.Windows.Forms.ToolStripMenuItem();
      this.colorDialog1 = new System.Windows.Forms.ColorDialog();
      this.toolStrip1 = new System.Windows.Forms.ToolStrip();
      this.tsbOpen = new System.Windows.Forms.ToolStripButton();
      this.tsbClose = new System.Windows.Forms.ToolStripButton();
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.tsslDateTime = new System.Windows.Forms.ToolStripStatusLabel();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.menuStrip1.SuspendLayout();
      this.toolStrip1.SuspendLayout();
      this.statusStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(663, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miOpen,
            this.miClose,
            this.toolStripSeparator1,
            this.miExit});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
      this.fileToolStripMenuItem.Text = "&File";
      // 
      // miOpen
      // 
      this.miOpen.Name = "miOpen";
      this.miOpen.Size = new System.Drawing.Size(180, 22);
      this.miOpen.Text = "&Open";
      this.miOpen.Click += new System.EventHandler(this.miOpen_Click);
      // 
      // miClose
      // 
      this.miClose.Enabled = false;
      this.miClose.Name = "miClose";
      this.miClose.Size = new System.Drawing.Size(180, 22);
      this.miClose.Text = "&Close";
      this.miClose.Click += new System.EventHandler(this.miClose_Click);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
      // 
      // miExit
      // 
      this.miExit.Name = "miExit";
      this.miExit.Size = new System.Drawing.Size(180, 22);
      this.miExit.Text = "E&xit";
      this.miExit.Click += new System.EventHandler(this.miExit_Click);
      // 
      // editToolStripMenuItem
      // 
      this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem});
      this.editToolStripMenuItem.Name = "editToolStripMenuItem";
      this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
      this.editToolStripMenuItem.Text = "&Edit";
      // 
      // colorToolStripMenuItem
      // 
      this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miColorRed,
            this.miColorGreen,
            this.miColorBlue,
            this.toolStripSeparator2,
            this.miColorCustom});
      this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
      this.colorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.colorToolStripMenuItem.Text = "&Color";
      // 
      // miColorRed
      // 
      this.miColorRed.Name = "miColorRed";
      this.miColorRed.Size = new System.Drawing.Size(180, 22);
      this.miColorRed.Text = "&Red";
      this.miColorRed.Click += new System.EventHandler(this.ChangeChildColor);
      // 
      // miColorGreen
      // 
      this.miColorGreen.Name = "miColorGreen";
      this.miColorGreen.Size = new System.Drawing.Size(180, 22);
      this.miColorGreen.Text = "&Green";
      this.miColorGreen.Click += new System.EventHandler(this.ChangeChildColor);
      // 
      // miColorBlue
      // 
      this.miColorBlue.Name = "miColorBlue";
      this.miColorBlue.Size = new System.Drawing.Size(180, 22);
      this.miColorBlue.Text = "&Blue";
      this.miColorBlue.Click += new System.EventHandler(this.ChangeChildColor);
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
      // 
      // miColorCustom
      // 
      this.miColorCustom.Name = "miColorCustom";
      this.miColorCustom.Size = new System.Drawing.Size(180, 22);
      this.miColorCustom.Text = "&Custom";
      this.miColorCustom.Click += new System.EventHandler(this.miColorCustom_Click);
      // 
      // toolStrip1
      // 
      this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbOpen,
            this.tsbClose});
      this.toolStrip1.Location = new System.Drawing.Point(0, 24);
      this.toolStrip1.Name = "toolStrip1";
      this.toolStrip1.Size = new System.Drawing.Size(663, 25);
      this.toolStrip1.TabIndex = 2;
      this.toolStrip1.Text = "toolStrip1";
      // 
      // tsbOpen
      // 
      this.tsbOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.tsbOpen.Image = ((System.Drawing.Image)(resources.GetObject("tsbOpen.Image")));
      this.tsbOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsbOpen.Name = "tsbOpen";
      this.tsbOpen.Size = new System.Drawing.Size(23, 22);
      this.tsbOpen.Text = "toolStripButton1";
      this.tsbOpen.Click += new System.EventHandler(this.tsbOpen_Click);
      // 
      // tsbClose
      // 
      this.tsbClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.tsbClose.Enabled = false;
      this.tsbClose.Image = ((System.Drawing.Image)(resources.GetObject("tsbClose.Image")));
      this.tsbClose.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsbClose.Name = "tsbClose";
      this.tsbClose.Size = new System.Drawing.Size(23, 22);
      this.tsbClose.Text = "toolStripButton1";
      this.tsbClose.Click += new System.EventHandler(this.tsbClose_Click);
      // 
      // statusStrip1
      // 
      this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslDateTime});
      this.statusStrip1.Location = new System.Drawing.Point(0, 395);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new System.Drawing.Size(663, 22);
      this.statusStrip1.TabIndex = 3;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // tsslDateTime
      // 
      this.tsslDateTime.AutoSize = false;
      this.tsslDateTime.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
      this.tsslDateTime.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedInner;
      this.tsslDateTime.Name = "tsslDateTime";
      this.tsslDateTime.Size = new System.Drawing.Size(150, 17);
      // 
      // timer1
      // 
      this.timer1.Enabled = true;
      this.timer1.Interval = 1000;
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(663, 417);
      this.Controls.Add(this.statusStrip1);
      this.Controls.Add(this.toolStrip1);
      this.Controls.Add(this.menuStrip1);
      this.IsMdiContainer = true;
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "Form1";
      this.Text = "Form1";
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      this.statusStrip1.ResumeLayout(false);
      this.statusStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem miOpen;
    private System.Windows.Forms.ToolStripMenuItem miClose;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripMenuItem miExit;
    private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem miColorRed;
    private System.Windows.Forms.ToolStripMenuItem miColorGreen;
    private System.Windows.Forms.ToolStripMenuItem miColorBlue;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripMenuItem miColorCustom;
    private System.Windows.Forms.ColorDialog colorDialog1;
    private System.Windows.Forms.ToolStrip toolStrip1;
    private System.Windows.Forms.ToolStripButton tsbOpen;
    private System.Windows.Forms.ToolStripButton tsbClose;
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.ToolStripStatusLabel tsslDateTime;
    private System.Windows.Forms.Timer timer1;
  }
}

