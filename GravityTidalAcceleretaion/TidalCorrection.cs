using System;
using FileHelpers;

namespace GravityTidalCorrection
{
    [IgnoreEmptyLines()]
    [IgnoreCommentedLines("#", true)]
    [DelimitedRecord("	")]
    public class TidalCorrection
    {

        [FieldConverter(ConverterKind.DateMultiFormat,"d-M-yy H:mm", "d-M-yyyy H:mm", "d-M-yyyy H:mm:ss")]
        private DateTime _date;
        private double _xpos;
        private double _ypos;
        private double _elev;
        
        [FieldNotInFile] private double _correctionTotal;
        [FieldNotInFile] private double _moonTidal;
        [FieldNotInFile] private double _sunTidal;

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }
        public double XPosition
        {
            get { return _xpos; }
            set { _xpos = value; }

        }
        public double YPosition
        {
            get { return _ypos; }
            set { _ypos = value; }
        }

        public double Elevation
        {
            get { return _elev; }
            set { _elev = value; }
        }

        public double MoonTidal
        {
            get { return _moonTidal; }
            set { _moonTidal = value; }
        }

        public double SunTidal
        {
            get { return _sunTidal; }
            set { _sunTidal = value; }
        }
        public double CorrectionTotal
        {
            get { return _correctionTotal;}
            set { _correctionTotal = value; }
        }

        public TidalCorrection (DateTime date, double x, double y, double elev, double gmoon, double gsun, double gtotal)
        {
            _date = date;
            _xpos = x;
            _ypos = y;
            _elev = elev;
            _moonTidal = gmoon;
            _sunTidal = gsun;
            _correctionTotal = gtotal;
        }

        public TidalCorrection()
        {
            
        }

    }
}
