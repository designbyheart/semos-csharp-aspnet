namespace Ex07 {
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
      this.label1 = new System.Windows.Forms.Label();
      this.tbSQL = new System.Windows.Forms.TextBox();
      this.btnGO = new System.Windows.Forms.Button();
      this.dgvResult = new System.Windows.Forms.DataGridView();
      ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(24, 13);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(31, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "SQL:";
      // 
      // tbSQL
      // 
      this.tbSQL.Location = new System.Drawing.Point(61, 12);
      this.tbSQL.Name = "tbSQL";
      this.tbSQL.Size = new System.Drawing.Size(314, 20);
      this.tbSQL.TabIndex = 1;
      this.tbSQL.Text = "SELECT * FROM State";
      // 
      // btnGO
      // 
      this.btnGO.Location = new System.Drawing.Point(391, 13);
      this.btnGO.Name = "btnGO";
      this.btnGO.Size = new System.Drawing.Size(75, 23);
      this.btnGO.TabIndex = 2;
      this.btnGO.Text = "GO";
      this.btnGO.UseVisualStyleBackColor = true;
      this.btnGO.Click += new System.EventHandler(this.btnGO_Click);
      // 
      // dgvResult
      // 
      this.dgvResult.AllowUserToAddRows = false;
      this.dgvResult.AllowUserToDeleteRows = false;
      this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvResult.Location = new System.Drawing.Point(27, 69);
      this.dgvResult.Name = "dgvResult";
      this.dgvResult.ReadOnly = true;
      this.dgvResult.Size = new System.Drawing.Size(439, 150);
      this.dgvResult.TabIndex = 3;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(565, 450);
      this.Controls.Add(this.dgvResult);
      this.Controls.Add(this.btnGO);
      this.Controls.Add(this.tbSQL);
      this.Controls.Add(this.label1);
      this.Name = "Form1";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox tbSQL;
    private System.Windows.Forms.Button btnGO;
    private System.Windows.Forms.DataGridView dgvResult;
  }
}

