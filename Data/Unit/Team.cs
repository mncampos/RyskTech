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

        public Team() { }
    }
}
