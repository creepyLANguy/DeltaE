using System;

namespace DeltaE
{
  class ColourspaceConversions
  {
    public static double[] XyzToLab(double x, double y, double z)
    {
      double[] lab = new double[3];

      x /= 95.047;
      y /= 100.0;
      z /= 108.883;

      if (x > 0.008856) { x = Math.Pow(x, (1.0 / 3.0)); }
      else { x = (7.787 * x) + (16 / 116); }

      if (y > 0.008856) { y = Math.Pow(y, (1.0 / 3.0)); }
      else { y = (7.787 * y) + (16 / 116); }

      if (z > 0.008856) { z = Math.Pow(z, (1.0 / 3.0)); }
      else { z = (7.787 * z) + (16 / 116); }

      double l = (116 * y) - 16;
      double a = 500 * (x - y);
      double b = 200 * (y - z);

      lab[0] = l;
      lab[1] = a;
      lab[2] = b;
      return lab;
    }

    public static double[] RgbToXyz(double r, double g, double b)
    {
      double[] xyz = new double[3];

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

      xyz[0] = x;
      xyz[1] = y;
      xyz[2] = z;
      return xyz;
    }
  }
}
