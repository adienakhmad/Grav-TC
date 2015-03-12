using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace GravityTidalCorrection
{
    public class UTMZone
    {
        private int zone;
        private bool isNorthHemisphere;
        private string displayName;

        public bool IsNorthHemisphere
        {
            get { return isNorthHemisphere; }
            set { isNorthHemisphere = value; }
        }
        public int Zone
        {
            get { return zone; }
            set { zone = value; }
        }
        public string DisplayName
        {
            get { return displayName; }
            set { displayName = value; }
        }

        public UTMZone(int mzone, bool hemisphere)
        {
            isNorthHemisphere = hemisphere;
            zone = mzone;

            if (isNorthHemisphere)
            {
                displayName = "WGS84 UTM Zone " + zone.ToString("00") + "N";
            }
            else
            {
                displayName = "WGS84 UTM Zone " + zone.ToString("00") + "S";
            }
            

        }
    }

    public static class UTMZoneInfo
    {
        public static ReadOnlyCollection<UTMZone> GetAllZones()
        {
            ReadOnlyCollection<UTMZone> zones;
            List<UTMZone> _utmZones = new List<UTMZone>();

            string[] hemisphere = new string[] {"N", "S"};

            for (int i = 0; i < 60; i++)
            {
                int zoneNumber = i + 1;
                bool isNorth = true;

                for (int j = 0; j < 2; j++)
                {
                    UTMZone zone = new UTMZone(zoneNumber, isNorth);
                    _utmZones.Add(zone);
                    isNorth = !isNorth;    
                }
              }

            zones = new ReadOnlyCollection<UTMZone>(_utmZones);
            return zones;

        }
    }
}
