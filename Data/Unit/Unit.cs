using RyskTech.Data;
using System.Collections.Generic;

namespace RyskTech
{
    public enum CivilianType { Publico, Estudantes, Docentes, Tecnico_Administrativos, Outros }

    public class Unit
    {
        public string name;
        public Location location;
        public string contactPhone;
        public string history;
        public string methodologyDescription;
        public List<Space> spaces;

        public Individual director;
        public Individual viceDirector;

        public int generalPublicCount;
        public int studentsCount;
        public int teachersCount;
        public int technicsCount;
        public int otherCount;
        public string otherDescription;

        public Unit() { }
    };
}
