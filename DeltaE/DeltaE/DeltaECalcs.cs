using System;

namespace DeltaE
{
  class DeltaECalcs
  {
    public static double Calc2000(double[] lab1, double[] lab2)
    {
      return 0;
    }

    public static double Calc94(double[] lab1, double[] lab2)
    {
      double l1 = lab1[0];
      double a1 = lab1[1];
      double b1 = lab1[2];
      double l2 = lab2[0];
      double a2 = lab2[1];
      double b2 = lab2[2];

      double k1 = 0.045;      // 0.045 graphic arts, 0.048 textiles
      double k2 = 0.015;      // 0.015 graphic arts, 0.014 textiles

      double kl = 1;         // 1 default, 2 textiles
      double kc = 1;
      double kh = 1;

      double xc1 = Math.Sqrt(Math.Pow(a1, 2) + Math.Pow(b1, 2));
      double xc2 = Math.Sqrt(Math.Pow(a2, 2) + Math.Pow(b2, 2));

      double sl = 1;
      double sc = 1 + k1 * xc1;
      double sh = 1 + k2 * xc1;

      double delta_L = l1 - l2;
      double delta_C = xc1 - xc2;
      double delta_a = a1 - a2;
      double delta_b = b1 - b2;

      double delta_H = 0;
      double deltaHCalc = Math.Pow(delta_a, 2) + Math.Pow(delta_b, 2) - Math.Pow(delta_C, 2);

      // Can't do a sqrt of a negative num
      if (deltaHCalc < 0)
      {
        delta_H = 0;
      }
      else
      {
        delta_H = Math.Sqrt(deltaHCalc);
      }

      // Make double sure that delta_H is non-negative 
      if (double.IsNaN(delta_H) || delta_H < 0)
      {
        delta_H = 0;
      }

      double lgroup = Math.Pow(delta_L / (kl * sl), 2);
      double cgroup = Math.Pow(delta_C / (kc * sc), 2);
      double hgroup = Math.Pow(delta_H / (kh * sh), 2);

      double delta94 = Math.Sqrt(lgroup + cgroup + hgroup);

      return delta94;
    }

    public static double Calc76(double[] lab1, double[] lab2)
    {
      var lDiff = Math.Pow(lab2[0] - lab1[0], 2);
      var aDiff = Math.Pow(lab2[1] - lab1[1], 2);
      var bDiff = Math.Pow(lab2[2] - lab1[2], 2);

      var delta76 = Math.Sqrt(lDiff + aDiff + bDiff);

      return delta76;
    }
  }
}
