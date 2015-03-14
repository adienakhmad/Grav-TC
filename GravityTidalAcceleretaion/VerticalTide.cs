using System;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;

namespace GravityTidalCorrection
{
    static class VerticalTide
    {
        // Constant
/*
        const double pi = 3.1415926535897;
*/
        const double mu = 6.67e-08;
        const double m = 7.3537e+25;
        const double s = 1.993e+33;
/*
        const double il = 0.08979719;
*/
/*
        const double omega = 0.4093146162;
*/
        const double ml = 0.074804;
        const double el = 0.0549;
        const double cl1 = 1.495e+13;
        const double cl = 3.84402e+10;
/*
        const double al = 6.37827e+08;
*/

        // Love Numbers
       private const double h2 = 0.612;
       private const double k2 = 0.303;

       private static double MjdToExcel(double n)
        {
            return n - 15018.0;
        }

        private static double FmjdToJ1900(double n)
        {
            return n - 15019.5;
        }

        private static double Poly(double t, double a, double b, double c, double d)
        {
            return a + (b*t) + (c * Math.Pow(t, 2)) + (d*Math.Pow(t, 3));
        }

        private static double Radian(double x)
        {
            return x/180.0*Math.PI;
        }

        private static double SQ2(double x)
        {
            return Math.Pow(x, 2);
        }

        private static double SQ3(double x)
        {
            return Math.Pow(x, 3);
        }

        private static double SQ4(double x)
        {
            return Math.Pow(x, 4);
        }

       // ReSharper disable once InconsistentNaming
        public static double UTC2ModifiedJulian(DateTime utcdate)
        {
            double hour = utcdate.Hour;
            double minute = utcdate.Minute;
            double second = utcdate.Second;

            int day = utcdate.Day;
            int month = utcdate.Month;
            int year = utcdate.Year;

            if (month < 3)
            {
                month += 12;
            }
            if (month > 12)
            {
                year -= 1;
            }
            if (month > 13)
            {
                day += 1;
            }

            int fmjd = (year * 365) + (year / 4) - (year / 100) + (year / 400) + (489 * month) / 16 + day - 678973;
            double result = fmjd + ((hour * 60.0 + minute) * 60.0 + second) / 86400.0;
            
            return result;

        }

        public static TidalCorrection TideCalcGal(double fmjd, double lat, double lon, double alt, double tz)
        {
            double tl0, j1900, t, n, el1, sl, pl, hl, pl1, i, nu, tl;
            double chi, chi1, ll1, cosalf, sinalf, alf, xi, sigma, ll, lm;
            double costht, cosphi, c, rl, ap, ap1, dl, D, gm, gs, g0, love;

            tl0 = (fmjd % 1.0) * 24.0;
            j1900 = FmjdToJ1900(fmjd);

            t = j1900/36525;
            n = Poly(t, 4.523601612, -33.75715303, 0.0000367488, 0.0000000387);
            el1 = Poly(t,0.01675104, -0.0000418, 0.000000126, 0);
            sl = Poly(t, 4.720023438, 8399.7093, 0.0000440695, 0.0000000329);
            pl = Poly(t, 5.835124721, 71.01800936, -0.0001805446, -0.0000002181);
            hl = Poly(t, 4.881627934, 628.3319508, 0.0000052796, 0);
            pl1 = Poly(t, 4.908229467, 0.0300052641, 7.9024e-06, 0.0000000581);
            i = Math.Acos(0.9136975738 - 0.0356895353 * Math.Cos(n));
            nu = Math.Asin(0.0896765581 * Math.Sin(n) / Math.Sin(i));
            tl = Radian(15 * tl0 + lon);
            chi = tl + hl - nu;
            chi1 = tl + hl;
            ll1 = hl + 2 * el1 * Math.Sin(hl - pl1);
            cosalf = Math.Cos(n) * Math.Cos(nu) + Math.Sin(n) * Math.Sin(nu) * 0.9173938078;
            sinalf = 0.3979806546 * Math.Sin(n) / Math.Sin(i);
            alf = 2 * Math.Atan(sinalf / (1 + cosalf));
            xi = n - alf;
            sigma = sl - xi;

            ll = sigma + 0.1098 * Math.Sin(sl - pl)
                    + 0.0037675125 * Math.Sin(2 * (sl - pl))
                    + 0.0154002735 * Math.Sin(sl - 2 * hl + pl)
                    + 0.0076940028 * Math.Sin(2 * (sl - hl));

            lm = Radian(lat);   // lamda
            costht = Math.Sin(lm) * Math.Sin(i) * Math.Sin(ll) + Math.Cos(lm) *
                (SQ2(Math.Cos(0.5 * i)) * Math.Cos(ll - chi) + SQ2(Math.Sin(0.5 * i)) * Math.Cos(ll + chi));
            cosphi = Math.Sin(lm) * 0.3979806546 * Math.Sin(ll1) + Math.Cos(lm) *
                (0.9586969039 * Math.Cos(ll1 - chi1) + 0.0413030961 * Math.Cos(ll1 + chi1));
            c = 1 / Math.Sqrt(1 + 0.006738 * SQ2(Math.Sin(lm)));

            rl = 6.37827e+08 * c + alt * 100.0; // meters to cm
            ap = 2.60930776e-11;
            ap1 = 1 / (1.495e+13 * (1 - el1 * el1));
            dl = 1 / (1 / cl
                + ap * el * Math.Cos(sl - pl)
                + ap * el * el * Math.Cos(2 * (sl - pl))
                + 1.875 * ap * ml * el * Math.Cos(sl - 2 * hl + pl)
                + ap * ml * ml * Math.Cos(2 * (sl - hl)));
            D = 1 / (1 / cl1
                + ap1 * el1 * Math.Cos(hl - pl1));
            gm = mu * m * rl * (3 * SQ2(costht) - 1) / SQ3(dl)
                + 1.5 * mu * m * rl * rl * (5 * SQ3(costht) - 3 * costht) / SQ4(dl);
            gs = mu * s * rl * (3 * SQ2(cosphi) - 1) / SQ3(D);
            love = (1 + h2 - 1.5 * k2);
            g0 = (gm + gs) * love;


            // in mGal
            var tidalAcceleration = new TidalCorrection(DateTime.FromOADate(MjdToExcel(fmjd) + (tz / 24.0)), lon, lat, alt, gm * love * 1e3, gs * love * 1e3, g0 * 1e3);
            return tidalAcceleration;
        }

    }
}
