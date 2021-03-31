using System;
using System.Text.RegularExpressions;

namespace RyskTech.Data
{
    public enum Occupation { Director, Vice_Director }

    public class Individual
    {
        private const string EMAIL_REGEX = "^\\S+@\\S+$";

        public string name;
        public string phone;
        public string eMail;
        public Occupation occupation;

        public Individual() { }

        public Individual(string name, string phone, string eMail, Occupation occupation)
        {
            this.name = name;
            this.phone = phone;
            this.eMail = eMail;
            this.occupation = occupation;
        }

        public string GetFormattedIndividualString()
        {
            string result = "";

            if (occupation == Occupation.Director)
                result += Resources.Language.pt_local.Director + " ";
            else
                result += Resources.Language.pt_local.ViceDirector + " ";

            result += name + ", ";
            result += Resources.Language.pt_local.Phone + " " + phone + ", ";
            result += Resources.Language.pt_local.EMail + " " + eMail;

            return result;
        }

        public void CheckValidity()
        {
            if (name == null || name.Length <= 0)
                throw new ApplicationException(Resources.Language.pt_local.InvalidName);

            if (phone == null || phone.Length <= 0)
                throw new ApplicationException(Resources.Language.pt_local.InvalidPhoneNumber);
        
            if (eMail == null || eMail.Length <= 0 || !Regex.Match(eMail, EMAIL_REGEX).Success)
                throw new ApplicationException(Resources.Language.pt_local.InvalidEmail);
        }
    }
}
