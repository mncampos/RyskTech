// Nuget package SyncFusion
using Syncfusion.DocIO.DLS;
using System.Collections.Generic;

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

    static class APR
    {
        // Chemical, Physical, Biological, Mechanic
        public static bool[] considered_agents = new bool[4];

        public static UnitInformation unit_info = new UnitInformation();

        public static bool LoadPrevious()
        {
            // TODO Try to load an old version of the form

            return false;
        }

        public static void FetchSpaceInformation()
        {
            // Read any information that has not been filled yet (mostly data view grids)
            unit_info.spaces = ((MainForm)System.Windows.Forms.Application.OpenForms["MainForm"]).getStructureData();
        }

        public static string GetLocationString()
        {
            string location = "";
            
            switch (unit_info.location.prefix)
            {
                case LocationPrefix.Rua:
                    location = "Rua ";
                    break;
                case LocationPrefix.Avenida:
                    location = "Avenida ";
                    break;
                case LocationPrefix.Alameda:
                    location = "Alameda ";
                    break;
                case LocationPrefix.Travessa:
                    location = "Travessa ";
                    break;
                case LocationPrefix.Rodovia:
                    location = "Rodovia ";
                    break;
                default:
                    break;
            }

            location += unit_info.location.street_name + ", ";
            location += "número " + unit_info.location.number + ", ";
            location += "bairro " + unit_info.location.neighborhood + ", ";
            location += "complemento " + unit_info.location.complement + ", ";
            location += "CEP " + unit_info.location.ZIP;

            return location;
        }

        public static List<string> GetDirectors()
        {
            string director = "";
            director += "Diretor: " + unit_info.team.director.name;
            director += ", Telefone: " + unit_info.team.director.phone;
            director += ", E-Mail: " + unit_info.team.director.e_mail;

            string vice_director = "";
            vice_director += "Vice-Diretor: " + unit_info.team.vice_director.name;
            vice_director += ", Telefone: " + unit_info.team.vice_director.phone;
            vice_director += ", E-Mail: " + unit_info.team.vice_director.e_mail;

            List<string> directors = new List<string>();
            directors.Add(director);
            directors.Add(vice_director);

            return directors;
        }
    }
}
