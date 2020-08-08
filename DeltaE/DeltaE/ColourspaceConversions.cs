using System;
using System.Drawing;

namespace DeltaE
{
  class ColourspaceConversions
  {
    public static XYZ RgbToXyz(Color c)
    {      
      RGB rgb;
      rgb.r = c.R;
      rgb.g = c.G;
      rgb.b = c.B;

      return RgbToXyz(rgb);
    }

    public static XYZ RgbToXyz(RGB rgb)
    {
      XYZ xyz;

      var r = rgb.r;
      var g = rgb.g;
      var b = rgb.b;

      r /= 255;
      g /= 255;
      b /= 255;

      if (r > 0.04045) { r = Math.Pow((r + 0.055) / 1.055, 2.4); }
      else { r /= 12.92; }

      if (g > 0.04045) { g = Math.Pow((g + 0.055) / 1.055, 2.4); }
      else { g /= 12.92; }

      if (b > 0.04045) { b = Math.Pow((b + 0.055) / 1.055, 2.4); }
      else { b /= 12.92; }

      r *= 100;
      g *= 100;
      b *= 100;

      double x = r * 0.4124 + g * 0.3576 + b * 0.1805;
      double y = r * 0.2126 + g * 0.7152 + b * 0.0722;
      double z = r * 0.0193 + g * 0.1192 + b * 0.9505;

      xyz.x = x;
      xyz.y = y;
      xyz.z = z;
      return xyz;
    }

    public static LAB XyzToLab(XYZ xyz)
    {
      LAB lab;

      var x = xyz.x;
      var y = xyz.y;
      var z = xyz.z;

      x /= 95.047;
      y /= 100.0;
      z /= 108.883;

      if (x > 0.008856) { x = Math.Pow(x, (1.0 / 3.0)); }
      else { x = (7.787 * x) + (16.0 / 116.0); }

      if (y > 0.008856) { y = Math.Pow(y, (1.0 / 3.0)); }
      else { y = (7.787 * y) + (16.0 / 116.0); }

      if (z > 0.008856) { z = Math.Pow(z, (1.0 / 3.0)); }
      else { z = (7.787 * z) + (16.0 / 116.0); }

      double l = (116 * y) - 16;
      double a = 500 * (x - y);
      double b = 200 * (y - z);

      lab.l = l;
      lab.a = a;
      lab.b = b;
      return lab;
    }
    }
  }
