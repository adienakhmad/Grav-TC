using System;
using FileHelpers;

namespace GravityTidalCorrection
{
    [IgnoreEmptyLines()]
    [IgnoreCommentedLines("#", true)]
    [DelimitedRecord("	")]
    public class TidalDatePosition
    {
        [FieldConverter(ConverterKind.Date,"dd-MM-yyyy HH:mm")]
        private DateTime _date;

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        private double _xpos;

        public double XPosition
        {
            get { return _xpos; } 
            set { _xpos = value; } 
            
        }
        private double _ypos;
        public double YPosition
        {
            get { return _ypos; }
            set { _ypos = value; }
        }
        
        [FieldNotInFile] private double _correctionTotal;
        public double CorrectionTotal
        {
            get { return _correctionTotal;}
            set { _correctionTotal = value; }
        }

    }
}
