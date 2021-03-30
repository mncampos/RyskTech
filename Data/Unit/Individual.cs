namespace RyskTech.Data
{
    public enum Occupation { Director, Vice_Director }

    public class Individual
    {
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
    }
}
