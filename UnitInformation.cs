using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RyskTech
{
    public enum LocationPrefix { Rua, Avenida, Alameda, Travessa, Rodovia }
    public enum CivilianType { Publico, Estudantes, Docentes, Tecnico_Administrativos, Outros }

    public class UnitInformation
    {
        // Name of the unit
        public string unit_name;

        // Location info
        public class LocationInformation
        {
            public LocationPrefix prefix;
            public string street_name;
            public uint number;
            public string neighborhood;
            public string ZIP;
            public string complement;
        }
        public LocationInformation location;

        // Relevant info about the surroundings
        public string surroundings;

        // Contact info
        public string phone;

        // Team info
        public class TeamInformation
        {
            public class ProfessionalInformation
            {
                public string name;
                public string e_mail;
                public string phone;
            }
            public ProfessionalInformation director;
            public ProfessionalInformation vice_director;

            public class CivilianInformation
            {
                public CivilianType kind;
                public string description;
                public uint count;

                public CivilianInformation(CivilianType kind, string desc)
                {
                    this.kind = kind;
                    if (kind == CivilianType.Outros)
                        this.description = desc;
                    else
                        this.description = "";
                    this.count = 0;
                }
            }

            public CivilianInformation general_public;
            public CivilianInformation students;
            public CivilianInformation teachers;
            public CivilianInformation technics;
            public CivilianInformation other;

            public TeamInformation()
            {
                director = new ProfessionalInformation();
                vice_director = new ProfessionalInformation();

                general_public = new CivilianInformation(CivilianType.Publico, null);
                students = new CivilianInformation(CivilianType.Estudantes, null);
                teachers = new CivilianInformation(CivilianType.Docentes, null);
                technics = new CivilianInformation(CivilianType.Tecnico_Administrativos, null);
            }
        }
        public TeamInformation team;

        // Structure info
        public class StructureInformation
        {
            public string building;
            public string room;
            public string floor;
            public System.TimeSpan turn_start;
            public System.TimeSpan turn_end;

            public StructureInformation()
            {
                building = "";
                room = "";
                floor = "";
                turn_start = new System.TimeSpan(0, 0, 0);
                turn_end = new System.TimeSpan(0, 0, 0);
            }
        }
        public List<StructureInformation> spaces;

        // History
        public string history;

        // Methodology
        public string methodology = "";

        public UnitInformation()
        {
            location = new LocationInformation();
            team = new TeamInformation();
        }
    };
}
