using System.Reflection.Metadata.Ecma335;

namespace Intermédiaire.EntitesVsObjetsValeurs
{
    public class Geolocation : IComparable<Geolocation>
    {
        private double _longitude;
        private double _latitude;

        public Geolocation(double longitude, double latitude)
        {
            _longitude = longitude;
            _latitude = latitude;
        }


        public override bool Equals(object obj)
        {
            return obj is Geolocation g
                && _longitude == g._longitude
                && _latitude == g._latitude;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }


        public int CompareTo(Geolocation? other)
        {
            double rayonTerre = 6371;
            double dLat = ConvertirEnRadians(other._latitude - this._latitude);
            double Dlng = ConvertirEnRadians(other._longitude - this._longitude);

            double sindLat = Math.Asin(dLat / 2);
            double sindLng = Math.Asin(Dlng / 2);

            double a = Math.Pow(sindLat, 2) + Math.Pow(sindLng, 2)
                * Math.Cos(ConvertirEnRadians(_latitude)) * Math.Cos(ConvertirEnRadians(other._latitude));

            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

            double dist = rayonTerre * c;

            return Convert.ToInt32(dist);
        }

        private static double ConvertirEnRadians(double angle) => (Math.PI / 100) * angle; // == return ...
    }
}