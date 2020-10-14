using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace DeltaE
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      System.Diagnostics.Process.Start(((LinkLabel)sender).Text);
    }

    private void ShowColourPicker(ColorDialog dialog, Button button)
    {
      colourPromptLabel.Hide();

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
      var xyz1 = ColourspaceConversions.RgbToXyz(c1);
      var lab1 = ColourspaceConversions.XyzToLab(xyz1);

      Color c2 = button2.BackColor;
      var xyz2 = ColourspaceConversions.RgbToXyz(c2);
      var lab2 = ColourspaceConversions.XyzToLab(xyz2);

      var de76 = DeltaECalcs.Calc76(lab1, lab2);
      var de94 = DeltaECalcs.Calc94(lab1, lab2);
      var de2000 = DeltaECalcs.Calc2000(lab1, lab2);

      cie76_textBox.Text = Math.Round(de76, Definitions.DECIMAL_PLACES).ToString(CultureInfo.CurrentCulture);
      cie94_textBox.Text = Math.Round(de94, Definitions.DECIMAL_PLACES).ToString(CultureInfo.CurrentCulture);
      cie2000_textBox.Text = Math.Round(de2000, Definitions.DECIMAL_PLACES).ToString(CultureInfo.CurrentCulture);

      rgb_label1.Text = c1.R + @"," + c1.G + @"," + c1.B;
      rgb_label2.Text = c2.R + @"," + c2.G + @"," + c2.B;

      this.Enabled = true;
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      DoCalcs();
    }
  }
}
