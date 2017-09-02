using System;
using FileHelpers;
// ReSharper disable InconsistentNaming

namespace GravityTidalCorrection
{
    [IgnoreEmptyLines()]
    [IgnoreCommentedLines("#", true)]
    [DelimitedRecord("	")]
    public class TidalRecord
    {

        [FieldConverter(ConverterKind.DateMultiFormat,"d-M-yy H:mm", "d-M-yyyy H:mm", "d-M-yyyy H:mm:ss")]
        private DateTime _date;
        private double _xpos;
        private double _ypos;
        private double _elev;
        
        [FieldNotInFile] private double _gTotal;
        [FieldNotInFile] private double _gMoon;
        [FieldNotInFile] private double _gSun;

        public DateTime Date
        {
            get => _date;
            set => _date = value;
        }
        public double XPosition
        {
            get => _xpos;
            set => _xpos = value;
        }
        public double YPosition
        {
            get => _ypos;
            set => _ypos = value;
        }

        public double Elevation
        {
            get => _elev;
            set => _elev = value;
        }

        public double gMoon
        {
            get => _gMoon;
            set => _gMoon = value;
        }

        public double gSun
        {
            get => _gSun;
            set => _gSun = value;
        }
        public double gTotal
        {
            get => _gTotal;
            set => _gTotal = value;
        }

        public TidalRecord (DateTime date, double x, double y, double elev, double gmoon, double gsun, double gtotal)
        {
            _date = date;
            _xpos = x;
            _ypos = y;
            _elev = elev;
            _gMoon = gmoon;
            _gSun = gsun;
            _gTotal = gtotal;
        }

        public TidalRecord()
        {
            
        }

    }
}
