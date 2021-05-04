using System;

namespace RyskTech.Data
{
    public class Team
    {
        public int generalPublicCount;
        public int studentsCount;
        public int teachersCount;
        public int technicsCount;
        public int otherCount;
        public string otherDescription;

        public Individual director;
        public Individual viceDirector;

        public string contactPhone;

        public Team()
        {
            director = new Individual();
            viceDirector = new Individual();

            generalPublicCount = 0;
            studentsCount = 0;
            teachersCount = 0;
            technicsCount = 0;
            otherCount = 0;
        }

        public void CheckValidity()
        {
            director.CheckValidity();

            viceDirector.CheckValidity();

            if (contactPhone == null || contactPhone.Length <= 0)
                throw new ApplicationException(Resources.Language.pt_local.InvalidPhoneNumber);

            if (generalPublicCount + studentsCount + technicsCount + teachersCount + otherCount == 0)
                throw new ApplicationException(Resources.Language.pt_local.IncompleteTeamCounter);
        }
    }
}
