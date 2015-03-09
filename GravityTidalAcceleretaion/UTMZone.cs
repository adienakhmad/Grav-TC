namespace Gravity
{
    class UTMZone
    {
        private int zone;

        public int Zone
        {
            get { return zone; }
            set { zone = value; }
        }
        private bool isNorthHemisphere;

        public bool IsNorthHemisphere
        {
            get { return isNorthHemisphere; }
            set { isNorthHemisphere = value; }
        }
        private string displayName;

        public string DisplayName
        {
            get { return displayName; }
            set { displayName = value; }
        }

        public UTMZone(string dispname, int mzone, bool hemisphere)
        {
            isNorthHemisphere = hemisphere;
            displayName = dispname;
            zone = mzone;
        }
    }
}
