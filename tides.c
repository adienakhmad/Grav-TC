//
// tides -- Compute variations in g due to lunar/solar tides.
//
// - User gives lat/lon of position.
// - Output is a table of variations in little g by date/time.
// - Both MJD (UTC) and Excel (local) dates are displayed.
// - g is reported in uGal units (micro-gals).
// - Lunar-only and Solar-only components are also displayed.
//
// Math calculation converted to C from QBASIC code found on
// the web. See author's original comments below.
//
// This program is used to better understand the performance
// of an ultra-precise free pendulum clock, which ultimately,
// if all mechanical and environmental effects were eliminated,
// is simply a gravimeter disguised as a clock.
//
// 09-Nov-2004 Tom Van Baak (tvb) www.LeapSecond.com/tools
//

#include <math.h>
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <time.h>

#if 0

From http://geophysics.ou.edu/gravmag/reduce/tide-acd.txt

'  TIDE-ACD.BAS
'
'       Copyright, 1993, J. L. Ahern
'
'  Calculates the acceleration due to the sun and moon at a given location,
'    for every hour, beginning at a specified hour, day, month and year.
'    Value calculated is the UPWARD pull due to the sun and moon. To use
'    as correction to measured gravity data, you would need to ADD these
'    numbers, not subtract them.  When the moon is overhead, for example
'    this program predicts a relatively large positive number, indicating
'    a large upward pull due to the moon. This would result in a DECREASE
'    in a gravity meter reading. Thus the tide value would be ADDED to
'    correct for this effect.
'
'    Based on equations presented by
'
'       Schureman, P., A manual of the harmonic analysis and prediction of
'         tides. U.S. Coast and Geodetic Survey, Spec. Pub. 98, 1924 (revised
'         in 1941 and 1958).
'
'  and collected by
'
'       Longman, I. M., Formulas for computing the tidal acceleration due to
'         the moon and the sun. J. Geophys. Res., 64, 2351-2355, 1959.
'
'  Love numbers from Stacey, Physics of the Earth.
'

From http://scienceworld.wolfram.com/physics/LoveNumber.html

    h is the ratio of the height of a body tide to the static
    marine tide (introduced by A. E. H. Love). k is ratio of
    additional potential produced by the redistribution of mass
    to the deforming potential (introduced by A. E. H. Love).
    l is the ratio of horizontal displacement of the crust to
    that of the equilibrium fluid tide (introduced by T. Shida).

From http://physics.ucsd.edu/~tmurphy/apollo/doc/tides.pdf

    The real earth does not have time to arrive at equilibrium
    with respect to the W2 tidal potential it rotates underneath.
    As such, an additional Love number, h, describes how much
    deflection the earth body experiences relative to that which
    would be expected directly from the perturbing potential.
    Empirically, the h, k, and l Love numbers are seen to be:
        h = 0.612,
        k = 0.303,
        l = 0.04.
    The definitions of these numbers are somewhat slippery, so I
    offer here my best interpretation of whatthese numbers mean.

    h describes the height (radial) displacement attained by the
    (solid) surface relative to what would have been attained by
    a perfectly fluid body in response to the perturbing force,
    neglecting the additional potential generated by the
    redistribution of matter. Therefore a perfectly fluid body
    in tidal equilibrium has h = 1+k (see below). The value
    h = 0.612 is presumably for the solid earth, with a value
    nearer unity for the oceans.

    k is the ratio of the potential contributed by the tidally
    deformed body to that of the perturbing potential (i.e., W2).
    A rigid body has k = 0 because there is no redistribution
    of matter. A uniform density fluid body has k = 3/2, and a
    fluid body with the earth's density profile has k = 0.94.
    The observed earth tidal response has k = 0.303 for the
    solid earth, and k = 0.245 for the earth-plus-oceans.
    I assume these are lower than the equilibrium value of 0.94
    because only the low-density exterior of the earth responds
    to the transient tidal disturbance.

#endif

long cal_to_mjd (long year, long month, long day);
double tide_calc_gal (double fmjd, double lat, double lon, double alt);
int find_arg (int argc, char *argv[], char *opt, double *val);

char *Usage =
    "Latitude (/lat:#) and Longitude (/long:#) required.\n\n"
    "Examples:\n"
    "  tides /lat:47 /long:-122 /alt:300\n"
    "  tides /lat:47 /long:-122 /tz:-8 /days:30\n\n"
    "Options:\n"
    "  /lat:# /long:# /alt:#\n"
    "  /year:# /month:# /day:# /hour:#\n"
    "  /days:# /mins:# /tz:#\n";

double tz;

void main (int argc, char *argv[])
{
    double fmjd, minute, ndays, nmins, val;
    time_t t1970;
    struct tm *tm;
    struct { double lat, lon, alt; } gps;
    struct { long year, month, day, hour, minute, second; } utc;

    // Get user specified location: latitude, longitude, altitude.

    if (!find_arg(argc, argv, "/lat:", &gps.lat) ||
        !find_arg(argc, argv, "/long:", &gps.lon) ) {
        fprintf(stderr, Usage);
        exit(1);
    }
    gps.alt = 0;
    find_arg(argc, argv, "/alt:", &gps.alt);

    // Get default start time (GMT).

    time(&t1970);
    tm = gmtime(&t1970);
    utc.year = 1900 + tm->tm_year;
    utc.month = 1 + tm->tm_mon;
    utc.day = tm->tm_mday;
    utc.hour = tm->tm_hour;
    utc.minute = 0;    // tm->tm_min;
    utc.second = 0;    // tm->tm_sec;

    // Get user specified date & time.

    if (find_arg(argc, argv, "/year:", &val)) {
        utc.year = (long) val;
    }
    if (find_arg(argc, argv, "/month:", &val)) {
        utc.month = (long) val;
    }
    if (find_arg(argc, argv, "/day:", &val)) {
        utc.day = (long) val;
    }
    if (find_arg(argc, argv, "/hour:", &val)) {
        utc.hour = (long) val;
    }

    fmjd = cal_to_mjd(utc.year, utc.month, utc.day);
    fmjd += ((utc.hour * 60.0 + utc.minute) * 60.0 + utc.second) / 86400.0;

    // Get user specified duration and interval.

    ndays = 7.0;
    find_arg(argc, argv, "/days:", &ndays);

    nmins = 60.0;
    find_arg(argc, argv, "/mins:", &nmins);

    // Set local timezone (to make Excel dates local time)

    tz = 0.0;
    find_arg(argc, argv, "/tz:", &tz);

    // Echo parameters.

    fprintf(stderr, "\nLunar/Solar Tide Calculator of acceleration of gravity\n");
    fprintf(stderr, "** Position: lat %.4lf long %.4lf alt %.0lf\n",
            gps.lat, gps.lon, gps.alt);
    fprintf(stderr, "** Begin time: %.4ld-%.2ld-%.2ld %.2ld:%.2ld:%.2ld UTC\n",
            utc.year, utc.month, utc.day, utc.hour, utc.minute, utc.second);
    fprintf(stderr, "** %g days duration, %g minutes per point", ndays, nmins);
    fprintf(stderr, ", timezone %g hours\n", tz);

    // Calculate a table of g variations in N minute increments.

    printf("Date (MJD), Date (Excel), Pendulum, g (m/s2), dg (uGals total), dg (Moon only), dg (Sun only)\n");

    for (minute = 0; minute <= ndays * 1440; minute += nmins) {
        tide_calc_gal(fmjd + minute / 1440.0, gps.lat, gps.lon, gps.alt);
    }
}

// Simple argument parsing: return true if argument is present
// and store floating point value if argument has parameter.
// E.g. /v /ns: /ns:123

int find_arg (int argc, char *argv[], char *opt, double *val)
{
    while (--argc > 0) {
        if (strncmp(argv[argc], opt, strlen(opt)) == 0) {
            if (strstr(opt, ":") != NULL) {
                *val = atof(&argv[argc][strlen(opt)]);
            }
            return 1;
        }
    }
    return 0;
}

// Convert Gregorian calendar date to Modified Julian Date (MJD).

long cal_to_mjd (long year, long month, long day)
{
    if (month < 3) month += 12;
    if (month > 12) year -= 1;
    if (month > 13) day += 1;
    return (year * 365) + (year / 4) - (year / 100) + (year / 400)
           + (489 * month) / 16
           + day - 678973;
}

// MJD to Excel date format
#define MJD_TO_EXCEL(n) ( (n) - 15018 )

// Days since 1900 Jan 0.5 // 1900-01-00 12h = 1899-12-31 12h = MJD 15019.5
#define fMJD_TO_J1900(n) ( (n) - 15019.5 )

// Seconds from 1970-01-01
#define MJD_TO_UNIX(n) ( ((n) - 40587) * 86400 )

#define SQ2(x) ( (x) * (x) )
#define SQ3(x) ( (x) * (x) * (x) )
#define SQ4(x) ( (x) * (x) * (x) * (x) )
#define POLY(t,a,b,c,d) ( (a) + (b) * (t) + (c) * SQ2(t) + d * SQ3(t) )
#define RAD(x) ( (x) / 180.0 * pi )

// Constants.

double pi = 3.1415926535897;
double mu = 6.67e-08;
double m = 7.3537e+25;
double s = 1.993e+33;
double il = 0.08979719;
double omega = 0.4093146162;
double ml = 0.074804;
double el = 0.0549;
double cl1 = 1.495e+13;
double cl = 3.84402e+10;
double al = 6.37827e+08;

// Love Numbers.

double h2 = 0.612;
double k2 = 0.303;

// Calculate lunar/solar tidal gravitational correction in uGal units
// given fractional MJD and position (latitude/longitude/altitude).
// Returns units of gals. Typical corrections are +/- 100 uGals.
// g is about 980 Gals; 980,000 mGals.
//
// Some of this code is a mystery to me and I have not independently
// verified its accuracy.

double tide_calc_gal (double fmjd, double lat, double lon, double alt)
{
    double tl0, j1900, t, n, el1, sl, pl, hl, pl1, i, nu, tl;
    double chi, chi1, ll1, cosalf, sinalf, alf, xi, sigma, ll, lm;
    double costht, cosphi, c, rl, ap, ap1, dl, D, gm, gs, g0, love;

    tl0 = fmod(fmjd, 1.0) * 24.0;
    j1900 = fMJD_TO_J1900(fmjd);
    t = j1900 / 36525;
    n = POLY(t, 4.523601612, -33.75715303, 0.0000367488, 0.0000000387);
    el1 = POLY(t, 0.01675104, -0.0000418, 0.000000126, 0);
    sl = POLY(t, 4.720023438, 8399.7093, 0.0000440695, 0.0000000329);
    pl = POLY(t, 5.835124721, 71.01800936, -0.0001805446, -0.0000002181);
    hl = POLY(t, 4.881627934,628.3319508, 0.0000052796, 0);
    pl1 = POLY(t, 4.908229467, 0.0300052641, 7.9024e-06, 0.0000000581);
    i = acos(0.9136975738 - 0.0356895353 * cos(n));
    nu = asin(0.0896765581 * sin(n) / sin(i));
    tl = RAD(15 * tl0 + lon);
    chi = tl + hl - nu;
    chi1 = tl + hl;
    ll1 = hl + 2 * el1 * sin(hl - pl1);
    cosalf = cos(n) * cos(nu) + sin(n) * sin(nu) * 0.9173938078;
    sinalf = 0.3979806546 * sin(n) / sin(i);
    alf = 2 * atan(sinalf / (1 + cosalf));
    xi = n - alf;
    sigma = sl - xi;
    ll = sigma + 0.1098 * sin(sl - pl)
        + 0.0037675125 * sin(2 * (sl - pl))
        + 0.0154002735 * sin(sl - 2 * hl + pl)
        + 0.0076940028 * sin(2 * (sl - hl));
    lm = RAD(lat);   // lamda
    costht = sin(lm) * sin(i) * sin(ll) + cos(lm) *
        ( SQ2(cos(0.5 * i)) * cos(ll - chi) + SQ2(sin(0.5 * i)) * cos(ll + chi) );
    cosphi = sin(lm) * 0.3979806546 * sin(ll1) + cos(lm) *
        ( 0.9586969039 * cos(ll1 - chi1) + 0.0413030961 * cos(ll1 + chi1) );
    c = 1 / sqrt(1 + 0.006738 * SQ2(sin(lm)));
    rl = 6.37827e+08 * c + alt * 100.0; // meters to cm
    ap = 2.60930776e-11;
    ap1 = 1 / (1.495e+13 * (1 - el1 * el1));
    dl = 1 / ( 1 / cl
        + ap * el * cos(sl - pl)
        + ap * el * el * cos(2 * (sl - pl))
        + 1.875 * ap * ml * el * cos(sl - 2 * hl + pl)
        + ap * ml * ml * cos(2 * (sl - hl)) );
    D = 1 / (1 / cl1
        + ap1 * el1 * cos(hl - pl1));
    gm = mu * m * rl * (3 * SQ2(costht) - 1) / SQ3(dl)
        + 1.5 * mu * m * rl * rl * (5 * SQ3(costht) - 3 * costht) / SQ4(dl);
    gs = mu * s * rl * (3 * SQ2(cosphi) - 1) / SQ3(D);
    love = (1 + h2 - 1.5 * k2);
    g0 = (gm + gs) * love;

#if 1
    printf("%.6lf,%.6lf,%.9le,%.3le,%.2lf,%.2lf,%.2lf\n",
           fmjd,
           MJD_TO_EXCEL(fmjd) + tz / 24.0,
           (980 - g0) / 100.0,  // g in m/s2 units
           -g0 / 980.0,         // pendulum clock rate
           g0 * 1e6,            // delta g in ugal units
           gm * love * 1e6, gs * love * 1e6);
#endif

    return g0;
}
