namespace DeltaE
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.linkLabel1 = new System.Windows.Forms.LinkLabel();
      this.colorDialog1 = new System.Windows.Forms.ColorDialog();
      this.colorDialog2 = new System.Windows.Forms.ColorDialog();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.textBox3 = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.linkLabel2 = new System.Windows.Forms.LinkLabel();
      this.linkLabel3 = new System.Windows.Forms.LinkLabel();
      this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.linkLabel4 = new System.Windows.Forms.LinkLabel();
      this.linkLabel5 = new System.Windows.Forms.LinkLabel();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.richTextBox1 = new System.Windows.Forms.RichTextBox();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.BackColor = System.Drawing.Color.Black;
      this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.button1.Location = new System.Drawing.Point(12, 12);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(117, 101);
      this.button1.TabIndex = 0;
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // button2
      // 
      this.button2.BackColor = System.Drawing.Color.White;
      this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.button2.Location = new System.Drawing.Point(135, 12);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(117, 101);
      this.button2.TabIndex = 0;
      this.button2.UseVisualStyleBackColor = false;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // textBox1
      // 
      this.textBox1.BackColor = System.Drawing.Color.White;
      this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBox1.Location = new System.Drawing.Point(12, 142);
      this.textBox1.Name = "textBox1";
      this.textBox1.ReadOnly = true;
      this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
      this.textBox1.Size = new System.Drawing.Size(75, 32);
      this.textBox1.TabIndex = 3;
      this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(26, 177);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(36, 13);
      this.label1.TabIndex = 4;
      this.label1.Text = "CIE76";
      // 
      // linkLabel1
      // 
      this.linkLabel1.AutoSize = true;
      this.linkLabel1.Location = new System.Drawing.Point(6, 21);
      this.linkLabel1.Name = "linkLabel1";
      this.linkLabel1.Size = new System.Drawing.Size(206, 13);
      this.linkLabel1.TabIndex = 5;
      this.linkLabel1.TabStop = true;
      this.linkLabel1.Text = "http://zschuessler.github.io/DeltaE/learn/";
      this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
      // 
      // textBox2
      // 
      this.textBox2.BackColor = System.Drawing.Color.White;
      this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBox2.Location = new System.Drawing.Point(93, 142);
      this.textBox2.Name = "textBox2";
      this.textBox2.ReadOnly = true;
      this.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
      this.textBox2.Size = new System.Drawing.Size(75, 32);
      this.textBox2.TabIndex = 8;
      this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // textBox3
      // 
      this.textBox3.BackColor = System.Drawing.Color.White;
      this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBox3.Location = new System.Drawing.Point(174, 142);
      this.textBox3.Name = "textBox3";
      this.textBox3.ReadOnly = true;
      this.textBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
      this.textBox3.Size = new System.Drawing.Size(75, 32);
      this.textBox3.TabIndex = 9;
      this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(111, 177);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(36, 13);
      this.label2.TabIndex = 10;
      this.label2.Text = "CIE94";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(184, 177);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(48, 13);
      this.label3.TabIndex = 10;
      this.label3.Text = "CIE2000";
      // 
      // linkLabel2
      // 
      this.linkLabel2.AutoSize = true;
      this.linkLabel2.Location = new System.Drawing.Point(6, 47);
      this.linkLabel2.Name = "linkLabel2";
      this.linkLabel2.Size = new System.Drawing.Size(191, 13);
      this.linkLabel2.TabIndex = 5;
      this.linkLabel2.TabStop = true;
      this.linkLabel2.Text = "http://www.easyrgb.com/en/math.php";
      this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
      // 
      // linkLabel3
      // 
      this.linkLabel3.AutoSize = true;
      this.linkLabel3.Location = new System.Drawing.Point(6, 73);
      this.linkLabel3.Name = "linkLabel3";
      this.linkLabel3.Size = new System.Drawing.Size(106, 13);
      this.linkLabel3.TabIndex = 5;
      this.linkLabel3.TabStop = true;
      this.linkLabel3.Text = "http://colormine.org/";
      this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(12, 116);
      this.label4.Name = "label4";
      this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.label4.Size = new System.Drawing.Size(31, 13);
      this.label4.TabIndex = 11;
      this.label4.Text = "0,0,0";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(133, 116);
      this.label5.Name = "label5";
      this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.label5.Size = new System.Drawing.Size(67, 13);
      this.label5.TabIndex = 11;
      this.label5.Text = "255,255,255";
      // 
      // linkLabel4
      // 
      this.linkLabel4.AutoSize = true;
      this.linkLabel4.Location = new System.Drawing.Point(6, 101);
      this.linkLabel4.Name = "linkLabel4";
      this.linkLabel4.Size = new System.Drawing.Size(201, 13);
      this.linkLabel4.TabIndex = 5;
      this.linkLabel4.TabStop = true;
      this.linkLabel4.Text = "https://github.com/gfiumara/CIEDE2000";
      this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
      // 
      // linkLabel5
      // 
      this.linkLabel5.AutoSize = true;
      this.linkLabel5.Location = new System.Drawing.Point(6, 131);
      this.linkLabel5.Name = "linkLabel5";
      this.linkLabel5.Size = new System.Drawing.Size(162, 13);
      this.linkLabel5.TabIndex = 5;
      this.linkLabel5.TabStop = true;
      this.linkLabel5.Text = "https://tinyurl.com/CIE94CSharp";
      this.linkLabel5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.linkLabel1);
      this.groupBox1.Controls.Add(this.linkLabel2);
      this.groupBox1.Controls.Add(this.linkLabel3);
      this.groupBox1.Controls.Add(this.linkLabel4);
      this.groupBox1.Controls.Add(this.linkLabel5);
      this.groupBox1.Location = new System.Drawing.Point(12, 291);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(240, 153);
      this.groupBox1.TabIndex = 12;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Resources";
      // 
      // richTextBox1
      // 
      this.richTextBox1.BackColor = System.Drawing.Color.White;
      this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.richTextBox1.Location = new System.Drawing.Point(12, 206);
      this.richTextBox1.Name = "richTextBox1";
      this.richTextBox1.ReadOnly = true;
      this.richTextBox1.Size = new System.Drawing.Size(243, 79);
      this.richTextBox1.TabIndex = 7;
      this.richTextBox1.Text = "<= 1 \tNot perceptible by human eyes.\n1 - 2 \tPerceptible through close observation" +
    ".\n2 - 10 \tPerceptible at a glance.\n11 - 49 \tColors are more similar than opposit" +
    "e.\n100 \tColors are exact opposite.\n";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(263, 453);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.textBox3);
      this.Controls.Add(this.textBox2);
      this.Controls.Add(this.richTextBox1);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Name = "Form1";
      this.Text = "DeltaE Calculator";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.LinkLabel linkLabel1;
    private System.Windows.Forms.ColorDialog colorDialog1;
    private System.Windows.Forms.ColorDialog colorDialog2;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.TextBox textBox3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.LinkLabel linkLabel2;
    private System.Windows.Forms.LinkLabel linkLabel3;
    private System.ComponentModel.BackgroundWorker backgroundWorker1;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.LinkLabel linkLabel4;
    private System.Windows.Forms.LinkLabel linkLabel5;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.RichTextBox richTextBox1;
  }
}

