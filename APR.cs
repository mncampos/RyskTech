// Nuget package SyncFusion
using Syncfusion.DocIO.DLS;

namespace RyskTech
{
    enum LocationPrefix { Rua, Avenida, Alameda, Travessa, Rodovia }
    enum CivilianType { Publico, Estudantes, Docentes, Tecnico_Administrativos, Outros }

    struct UnitInformation
    {
        // Name of the unit
        string unit_name;

        // Location info
        struct LocationInformation
        {
            LocationPrefix prefix;
            uint number;
            string neighborhood;
            string ZIP;
            string complement;
        }
        LocationInformation location;

        // Relevant info about the surroundings
        string surroundings;

        // Contact info
        string phone;

        // Team info
        struct TeamInformation
        {
            struct ProfessionalInformation
            {
                string name;
                string e_mail;
                string phone;
            }
            ProfessionalInformation director;
            ProfessionalInformation vice_director;

            struct CivilianInformation
            {
                CivilianType kind;
                string description;
                uint count;

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

            CivilianInformation general_public;
            CivilianInformation students;
            CivilianInformation teachers;
            CivilianInformation technics;
            CivilianInformation[] other;
        }
        TeamInformation team;

        // Structure info
        struct StructureInformation
        {
            string building;
            string room;
            string floor;
            System.TimeSpan turn_start;
            System.TimeSpan turn_end;
        }
        StructureInformation[] spaces;

        // History
        string history;

        // Methodology
        string methodology;

    };

    static class APR
    {
        // Chemical, Physical, Biological, Mechanic
        public static bool[] considered_agents = new bool[4];

        // Information about the unit
        public static UnitInformation unit_info;

        public static bool LoadPrevious()
        {
            // TODO Try to load an old version of the form

            return false;
        }

        public static void GenerateDocument()
        {
            // TODO generate document here with all the information
            using (WordDocument document = new WordDocument())
            {
                // Add section and paragraph for testing
                document.EnsureMinimal();

                // Append some text to the document
                document.LastParagraph.AppendText("Testing");

                // Save
                document.Save("output.docx");
            }
        }
    }
}
