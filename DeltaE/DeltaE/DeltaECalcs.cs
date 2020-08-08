using System;

namespace DeltaE
{
  class DeltaECalcs
  {
    private static double deg2Rad(double deg)
    {
      return (deg * (Definitions.M_PI / 180.0));
    }

    /*
     * CIE2000 ported from Greg Fiumara's C++ implementation:
     * https://github.com/gfiumara/CIEDE2000
     */
    public static double Calc2000(LAB lab1, LAB lab2)
    {
      double k_L = 1.0;
      double k_C = 1.0;
      double k_H = 1.0;

      double deg360InRad = deg2Rad(360.0);
      double deg180InRad = deg2Rad(180.0);
      double pow25To7 = 6103515625.0; /* pow(25, 7) */

      /*
	     * Step 1 
	     */
      /* Equation 2 */
      double C1 = Math.Sqrt((lab1.a * lab1.a) + (lab1.b * lab1.b));
      double C2 = Math.Sqrt((lab2.a * lab2.a) + (lab2.b * lab2.b));
      /* Equation 3 */
      double barC = (C1 + C2) / 2.0;
      /* Equation 4 */
      double G = 0.5 * (1 - Math.Sqrt(Math.Pow(barC, 7) / (Math.Pow(barC, 7) + pow25To7)));
      /* Equation 5 */
      double a1Prime = (1.0 + G) * lab1.a;
      double a2Prime = (1.0 + G) * lab2.a;
      /* Equation 6 */
      double CPrime1 = Math.Sqrt((a1Prime * a1Prime) + (lab1.b * lab1.b));
      double CPrime2 = Math.Sqrt((a2Prime * a2Prime) + (lab2.b * lab2.b));
      /* Equation 7 */
      double hPrime1;
      if (lab1.b == 0 && a1Prime == 0)
        hPrime1 = 0.0;
      else
      {
        hPrime1 = Math.Atan2(lab1.b, a1Prime);
        /* 
         * This must be converted to a hue angle in degrees between 0 
         * and 360 by addition of 2􏰏 to negative hue angles.
         */
        if (hPrime1 < 0)
          hPrime1 += deg360InRad;
      }
      double hPrime2;
      if (lab2.b == 0 && a2Prime == 0)
        hPrime2 = 0.0;
      else
      {
        hPrime2 = Math.Atan2(lab2.b, a2Prime);
        /* 
         * This must be converted to a hue angle in degrees between 0 
         * and 360 by addition of 2􏰏 to negative hue angles.
         */
        if (hPrime2 < 0)
          hPrime2 += deg360InRad;
      }


      /*
	     * Step 2
	     */
      /* Equation 8 */
      double deltaLPrime = lab2.l - lab1.l;
      /* Equation 9 */
      double deltaCPrime = CPrime2 - CPrime1;
      /* Equation 10 */
      double deltahPrime;
      double CPrimeProduct = CPrime1 * CPrime2;
      if (CPrimeProduct == 0)
        deltahPrime = 0;
      else
      {
        /* Avoid the fabs() call */
        deltahPrime = hPrime2 - hPrime1;
        if (deltahPrime < -deg180InRad)
          deltahPrime += deg360InRad;
        else if (deltahPrime > deg180InRad)
          deltahPrime -= deg360InRad;
      }
      /* Equation 11 */
      double deltaHPrime = 2.0 * Math.Sqrt(CPrimeProduct) *
          Math.Sin(deltahPrime / 2.0);


      /*
       * Step 3
       */
      /* Equation 12 */
      double barLPrime = (lab1.l + lab2.l) / 2.0;
      /* Equation 13 */
      double barCPrime = (CPrime1 + CPrime2) / 2.0;
      /* Equation 14 */
      double barhPrime, hPrimeSum = hPrime1 + hPrime2;
      if (CPrime1 * CPrime2 == 0)
      {
        barhPrime = hPrimeSum;
      }
      else
      {
        if (Math.Abs(hPrime1 - hPrime2) <= deg180InRad)
          barhPrime = hPrimeSum / 2.0;
        else
        {
          if (hPrimeSum < deg360InRad)
            barhPrime = (hPrimeSum + deg360InRad) / 2.0;
          else
            barhPrime = (hPrimeSum - deg360InRad) / 2.0;
        }
      }
      /* Equation 15 */
      double T = 1.0 - (0.17 * Math.Cos(barhPrime - deg2Rad(30.0))) +
          (0.24 * Math.Cos(2.0 * barhPrime)) +
          (0.32 * Math.Cos((3.0 * barhPrime) + deg2Rad(6.0))) -
          (0.20 * Math.Cos((4.0 * barhPrime) - deg2Rad(63.0)));
      /* Equation 16 */
      double deltaTheta = deg2Rad(30.0) *
          Math.Exp(-1 * (Math.Pow((barhPrime - deg2Rad(275.0)) / deg2Rad(25.0), 2.0)));
      /* Equation 17 */
      double R_C = 2.0 * Math.Sqrt(Math.Pow(barCPrime, 7.0) /
          (Math.Pow(barCPrime, 7.0) + pow25To7));
      /* Equation 18 */
      double S_L = 1 + ((0.015 * Math.Pow(barLPrime - 50.0, 2.0)) /
          Math.Sqrt(20 + Math.Pow(barLPrime - 50.0, 2.0)));
      /* Equation 19 */
      double S_C = 1 + (0.045 * barCPrime);
      /* Equation 20 */
      double S_H = 1 + (0.015 * barCPrime * T);
      /* Equation 21 */
      double R_T = (-1 * (Math.Sin(2.0 * deltaTheta))) * R_C;

      /* Equation 22 */
      double deltaE = Math.Sqrt(
          Math.Pow(deltaLPrime / (k_L * S_L), 2.0) +
          Math.Pow(deltaCPrime / (k_C * S_C), 2.0) +
          Math.Pow(deltaHPrime / (k_H * S_H), 2.0) +
          (R_T * (deltaCPrime / (k_C * S_C)) * (deltaHPrime / (k_H * S_H))));

      return (deltaE);
    }

    /*
     * CIE94 implemtation was kifted almost verbatim from Shaun Lynch's blog:
     * https://blog.genreof.com/post/comparing-colors-using-delta-e-1994-in-c
     */
    public static double Calc94(LAB lab1, LAB lab2)
    {
      double k1 = 0.045;      // 0.045 graphic arts, 0.048 textiles
      double k2 = 0.015;      // 0.015 graphic arts, 0.014 textiles

      double kl = 1;         // 1 default, 2 textiles
      double kc = 1;
      double kh = 1;

      double xc1 = Math.Sqrt(Math.Pow(lab1.a, 2) + Math.Pow(lab1.b, 2));
      double xc2 = Math.Sqrt(Math.Pow(lab2.a, 2) + Math.Pow(lab2.b, 2));

      double sl = 1;
      double sc = 1 + k1 * xc1;
      double sh = 1 + k2 * xc1;

      double delta_L = lab1.l - lab2.l;
      double delta_C = xc1 - xc2;
      double delta_a = lab1.a - lab2.a;
      double delta_b = lab1.b - lab2.b;

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

    public static double Calc76(LAB lab1, LAB lab2)
    {
      var lDiff = Math.Pow(lab2.l - lab1.l, 2);
      var aDiff = Math.Pow(lab2.a - lab1.a, 2);
      var bDiff = Math.Pow(lab2.b - lab1.b, 2);

      var delta76 = Math.Sqrt(lDiff + aDiff + bDiff);

      return delta76;
    }
  }
}
