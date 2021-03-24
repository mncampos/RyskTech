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

        // Information about the unit
        public static UnitInformation unit_info = new UnitInformation();

        public static bool LoadPrevious()
        {
            // TODO Try to load an old version of the form

            return false;
        }

        public static void GenerateDocument()
        {
            // Read any information that has not been filled yet (mostly data view grids)
            unit_info.spaces = ((MostAdvanced)System.Windows.Forms.Application.OpenForms["MostAdvanced"]).getStructureData();

            // TODO generate document here with all the information
            using (WordDocument document = new WordDocument())
            {
                document.EnsureMinimal();

                // Write unit structure section
                IWSection unit_structure_section = document.AddSection();
                unit_structure_section.PageSetup.Margins.All = 50f;
                IWParagraph unit_structure_paragraph = unit_structure_section.AddParagraph();
                unit_structure_paragraph.ParagraphFormat.HorizontalAlignment = HorizontalAlignment.Justify;
                IWTextRange unit_structure_text_range = unit_structure_paragraph.AppendText("A unidade utiliza os seguintes espaços: ");

                // Create table with rooms, buildings and time ranges
                IWTable unit_spaces_table = unit_structure_section.AddTable();
                unit_spaces_table.ResetCells(unit_info.spaces.Count + 1, 4);
                unit_spaces_table[0, 0].AddParagraph().AppendText("Prédio");
                unit_spaces_table[0, 1].AddParagraph().AppendText("Sala");
                unit_spaces_table[0, 2].AddParagraph().AppendText("Andar");
                unit_spaces_table[0, 3].AddParagraph().AppendText("Período de uso");
                for (int i = 0; i < unit_info.spaces.Count; i++)
                {
                    unit_spaces_table[i + 1, 0].AddParagraph().AppendText(unit_info.spaces[i].building);
                    unit_spaces_table[i + 1, 1].AddParagraph().AppendText(unit_info.spaces[i].room);
                    unit_spaces_table[i + 1, 2].AddParagraph().AppendText(unit_info.spaces[i].floor);
                    unit_spaces_table[i + 1, 3].AddParagraph().AppendText(unit_info.spaces[i].turn_start.ToString() + " - " + unit_info.spaces[i].turn_end.ToString());
                }

                // Write unit surroundings section
                //IWSection unit_surroundings_section = document.AddSection();
                //unit_surroundings_section.PageSetup.Margins.All = 50f;
                IWParagraph unit_surrounding_paragraph = unit_structure_section.AddParagraph();
                unit_surrounding_paragraph.ParagraphFormat.HorizontalAlignment = HorizontalAlignment.Justify;
                IWTextRange unit_surrounding_text_range = unit_surrounding_paragraph.AppendText(unit_info.surroundings);

                // Write unit history section
                //IWSection unit_history_section = document.AddSection();
                //unit_history_section.PageSetup.Margins.All = 50f;
                IWParagraph unit_history_paragraph = unit_structure_section.AddParagraph();
                unit_history_paragraph.ParagraphFormat.HorizontalAlignment = HorizontalAlignment.Justify;
                IWTextRange history_text_range = unit_history_paragraph.AppendText(unit_info.history);

                // Write unit methodology section
                //IWSection unit_methodology_section = document.AddSection();
                //unit_methodology_section.PageSetup.Margins.All = 50f;
                IWParagraph unit_methodology_paragraph = unit_structure_section.AddParagraph();
                unit_methodology_paragraph.ParagraphFormat.HorizontalAlignment = HorizontalAlignment.Justify;
                IWTextRange methodology_text_range = unit_methodology_paragraph.AppendText(unit_info.methodology);

                // Save & close
                document.Save("output.docx", Syncfusion.DocIO.FormatType.Docx);
                document.Close();
            }
        }
    }
}
