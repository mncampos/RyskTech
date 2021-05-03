using System;
using System.Text;
using System.Text.RegularExpressions;


namespace RyskTech.Data
{
    public enum LocationPrefix { Road, Avenue, Boulevard, Crossing, Highway, Invalid }

    public class Location
    {
        private const string ZIPCODE_REGEX = "^\\d{5}-\\d{3}$";

        public LocationPrefix prefix;
        public string streetName;
        public int streetNumber;
        public string district;
        public string ZIPCode;
        public string complement;
        public string surroundingsDetails;

        public Location() 
        {
            prefix = LocationPrefix.Invalid;
            streetNumber = -1;
        }

        public Location(LocationPrefix prefix, string streetName, int streetNumber, string district, string ZIPCode, string complement)
        {
            this.prefix = prefix;
            this.streetName = streetName;
            this.streetNumber = streetNumber;
            this.district = district;
            this.ZIPCode = ZIPCode;
            this.complement = complement;
        }

        public string GetFormattedLocationString()
        {
            string location = "";

            switch (this.prefix)
            {
                case LocationPrefix.Road:
                    location = Resources.Language.pt_local.Road;
                    break;
                case LocationPrefix.Avenue:
                    location = Resources.Language.pt_local.Avenue;
                    break;
                case LocationPrefix.Boulevard:
                    location = Resources.Language.pt_local.Boulevard;
                    break;
                case LocationPrefix.Crossing:
                    location = Resources.Language.pt_local.Crossing;
                    break;
                case LocationPrefix.Highway:
                    location = Resources.Language.pt_local.Highway;
                    break;
                default:
                    break;
            }

            location += " " + streetName + ", ";
            location += Resources.Language.pt_local.No + " " + streetNumber + ", ";
            location += Resources.Language.pt_local.District + " " + district + ", ";
            location += Resources.Language.pt_local.AddressComplement + " " + complement + ", ";
            location += Resources.Language.pt_local.AddressZIP + " " + ZIPCode;

            return location;
        }

        public string GetGoogleMapsSearchURL()
        {
            StringBuilder address = new StringBuilder();
            address.Append("https://maps.google.com/maps?q=");

            if (streetName != null)
            {
                address.Append(streetName + "," + "+");
            }

            if (district != null)
            {
                address.Append(district + "," + "+");
            }
            
            address.Append(ZIPCode + ",");
            address.Append("&#8221&z=15");
            
            byte[] tempBytes;
            tempBytes = System.Text.Encoding.GetEncoding("ISO-8859-8").GetBytes(address.ToString());
            string asciiStr = System.Text.Encoding.UTF8.GetString(tempBytes);

            return asciiStr;
        }

        public void CheckValidity()
        {
            if (prefix == LocationPrefix.Invalid)
                throw new ApplicationException(Resources.Language.pt_local.LocationPrefixInvalid);

            if (streetName == null || streetName.Length <= 0)
                throw new ApplicationException(Resources.Language.pt_local.LocationStreetInvalid);

            if (streetNumber <= 0)
                throw new ApplicationException(Resources.Language.pt_local.LocationNumberInvalid);

            if (district == null || district.Length <= 0)
                throw new ApplicationException(Resources.Language.pt_local.LocationDistrictInvalid);

            if (ZIPCode == null || !Regex.Match(ZIPCode, ZIPCODE_REGEX).Success)
                throw new ApplicationException(Resources.Language.pt_local.LocationZIPInvalid);
        }

    }
}
