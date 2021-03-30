using System.Text;
using System.Text.RegularExpressions;


namespace RyskTech.Data
{
    public enum LocationPrefix { Road, Avenue, Boulevard, Crossing, Highway, Invalid }

    public class Location
    {
        private const string ZIPCODE_REGEX = "^\\d{5}-\\d{3}}$";

        public LocationPrefix prefix = LocationPrefix.Invalid;
        public string streetName;
        public int streetNumber = -1;
        public string district;
        public string ZIPCode;
        public string complement;
        public string surroundingsDetails;

        public Location() { }

        public Location(LocationPrefix prefix, string streetName, int streetNumber, string district, string ZIPCode, string complement, string surroundingsDetails)
        {
            this.prefix = prefix;
            this.streetName = streetName;
            this.streetNumber = streetNumber;
            this.district = district;
            this.ZIPCode = ZIPCode;
            this.complement = complement;
            this.surroundingsDetails = surroundingsDetails;
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
            string city = "Porto Alegre";
            string state = "RS";

            StringBuilder address = new StringBuilder();
            address.Append("https://maps.google.com/maps?q=");

            if (streetName != null)
            {
                address.Append(streetName + "," + "+");
            }

            address.Append(city + "," + "+");
            address.Append(state + "," + "+");

            return address.ToString();
        }

        public void CheckForErrorsOrIncompleteFields()
        {
            string errorListing = "";
            
            // TODO create exceptions for each of these cases
            bool status = prefix != LocationPrefix.Invalid
                && streetName != null
                && streetNumber != -1
                && district != null
                && ZIPCode != null && Regex.Match(ZIPCode, ZIPCODE_REGEX).Success
                && complement != null
                && surroundingsDetails != null;
            

            if (errorListing.Length > 0)
                throw new System.ApplicationException(errorListing);
        }
    
    }
}
