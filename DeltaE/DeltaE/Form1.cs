using System;
using System.Drawing;
using System.Windows.Forms;

namespace DeltaE
{
  public partial class Form1 : Form
  {
    private static readonly int DECIMAL_PLACES = 2;

    public Form1()
    {
      InitializeComponent();
    }

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      System.Diagnostics.Process.Start(linkLabel1.Text);
    }
    private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      System.Diagnostics.Process.Start(linkLabel2.Text);
    }
    private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      System.Diagnostics.Process.Start(linkLabel3.Text);
    }

    private void ShowColourPicker(ColorDialog dialog, Button button)
    {
      dialog.AnyColor = true;
      dialog.AllowFullOpen = true;
      dialog.FullOpen = true;
      dialog.AnyColor = true;
      if (dialog.ShowDialog() == DialogResult.OK)
      {
        button.BackColor = dialog.Color;
        DoCalcs();
      }
    }

    private void button1_Click(object sender, EventArgs e)
    {
      ShowColourPicker(colorDialog1, button1);
    }

    private void button2_Click(object sender, EventArgs e)
    {
      ShowColourPicker(colorDialog2, button2);
    }

    private void DoCalcs()
    {
      this.Enabled = false;
      Color c1 = button1.BackColor;
      var xyz1 = ColourspaceConversions.RgbToXyz(c1.R, c1.G, c1.B);
      var lab1 = ColourspaceConversions.XyzToLab(xyz1[0], xyz1[1], xyz1[2]);

      Color c2 = button2.BackColor;
      var xyz2 = ColourspaceConversions.RgbToXyz(c2.R, c2.G, c2.B);
      var lab2 = ColourspaceConversions.XyzToLab(xyz2[0], xyz2[1], xyz2[2]);

      var de76 = DeltaECalcs.Calc76(lab1, lab2);
      var de94 = DeltaECalcs.Calc94(lab1, lab2);
      var de2000 = DeltaECalcs.Calc2000(lab1, lab2);

      textBox1.Text = Math.Round(de76, DECIMAL_PLACES).ToString();
      textBox2.Text = Math.Round(de94, DECIMAL_PLACES).ToString();
      textBox3.Text = Math.Round(de2000, DECIMAL_PLACES).ToString();
      this.Enabled = true;
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      DoCalcs();
    }
  }
}
