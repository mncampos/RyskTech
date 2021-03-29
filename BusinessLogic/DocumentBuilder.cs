// Nuget package SyncFusion
using Syncfusion.DocIO.DLS;
using System.Collections.Generic;

namespace RyskTech
{
    class DocumentBuilder
    {
        private string documentName;
        private WordDocument documentReference;

        public DocumentBuilder(string documentName)
        {
            this.documentName = documentName;

            this.documentReference = new WordDocument();
            this.documentReference.EnsureMinimal();
        }

        public int CreateDocumentFromAPR()
        {
            AddUnitInformation();

            // TODO Do this for every lab
            //AddLabInformation();

            this.documentReference.Save(documentName, Syncfusion.DocIO.FormatType.Docx);
            this.documentReference.Close();

            return 0;
        }

        private void AddUnitInformation()
        {
            // Objective and abrangency
            // TODO Where is this information supposed to come from?

            AddUnitTeamInformation();
            AddUnitLocationInformation();
            AddUnitStructureInformation();
            AddUnitHistoryInformation();
            AddAPRMethodologyInformation();

            // TODO Anything else?
        }

        private void AddLabInformation()
        {
            // TODO when we have this info
        }

        private void AddUnitTeamInformation()
        {
            List<string> directors = APR.GetDirectors();

            AddSectionWithTitle(this.documentReference.Sections.Count + ". Equipe");
            AddTextParagraph("A unidade tem como equipe da direção: ");
            AddListWithItems(directors);
            AddTextParagraph("A composição do pessoal presente na unidade se encontra na tabela abaixo: ");
            AddTeamCompositionTable();
            AddTextParagraph("Para entrar em contato com a unidade, utilizar o telefone " + APR.unit_info.phone);
        }

        private void AddUnitLocationInformation()
        {
            AddSectionWithTitle(this.documentReference.Sections.Count + ". Localização");
            AddTextParagraph("A unidade está localizada em " + APR.GetLocationString() + "." + APR.unit_info.surroundings);
        }

        private void AddUnitStructureInformation()
        {
            AddSectionWithTitle(this.documentReference.Sections.Count + ". Estrutura");
            AddTextParagraph("A unidade utiliza os seguintes espaços: ");
            AddRoomsBuildingsTimesTable();
        }

        private void AddUnitHistoryInformation()
        {
            AddSectionWithTitle(this.documentReference.Sections.Count + ". Histórico");
            AddTextParagraph(APR.unit_info.history);
        }

        private void AddAPRMethodologyInformation()
        {
            AddSectionWithTitle(this.documentReference.Sections.Count + ". Metodologia");
            AddTextParagraph(APR.unit_info.methodology);
        }

        private void AddRoomsBuildingsTimesTable()
        {
            // We need to do this so the information is updated in the APR class
            APR.FetchSpaceInformation();

            // Create table with rooms, buildings and time ranges
            IWTable unit_spaces_table = GetCurrentSection().AddTable();
            unit_spaces_table.ResetCells(APR.unit_info.spaces.Count + 1, 4);
            unit_spaces_table[0, 0].AddParagraph().AppendText("Prédio");
            unit_spaces_table[0, 1].AddParagraph().AppendText("Sala");
            unit_spaces_table[0, 2].AddParagraph().AppendText("Andar");
            unit_spaces_table[0, 3].AddParagraph().AppendText("Período de uso");
            for (int i = 0; i < APR.unit_info.spaces.Count; i++)
            {
                unit_spaces_table[i + 1, 0].AddParagraph().AppendText(APR.unit_info.spaces[i].building);
                unit_spaces_table[i + 1, 1].AddParagraph().AppendText(APR.unit_info.spaces[i].room);
                unit_spaces_table[i + 1, 2].AddParagraph().AppendText(APR.unit_info.spaces[i].floor);
                unit_spaces_table[i + 1, 3].AddParagraph().AppendText(APR.unit_info.spaces[i].turn_start.ToString() + " - " + APR.unit_info.spaces[i].turn_end.ToString());
            }
        }

        private void AddTeamCompositionTable()
        {
            IWTable unit_team_table = GetCurrentSection().AddTable();
            unit_team_table.ResetCells(6, 2);
            unit_team_table[0, 0].AddParagraph().AppendText("Tipo");
            unit_team_table[0, 1].AddParagraph().AppendText("Quantidade");

            // Public
            unit_team_table[1, 0].AddParagraph().AppendText("Público");
            unit_team_table[1, 1].AddParagraph().AppendText(APR.unit_info.team.general_public.count.ToString());

            // Students
            unit_team_table[2, 0].AddParagraph().AppendText("Alunos e Estudantes");
            unit_team_table[2, 1].AddParagraph().AppendText(APR.unit_info.team.students.count.ToString());

            // Teachers
            unit_team_table[3, 0].AddParagraph().AppendText("Professores");
            unit_team_table[3, 1].AddParagraph().AppendText(APR.unit_info.team.teachers.count.ToString());

            // Technics
            unit_team_table[4, 0].AddParagraph().AppendText("Profissionais Técnico-Administrativos");
            unit_team_table[4, 1].AddParagraph().AppendText(APR.unit_info.team.technics.count.ToString());

            // Technics
            if (APR.unit_info.team.other != null)
            {
                unit_team_table[5, 0].AddParagraph().AppendText(APR.unit_info.team.other.description);
                unit_team_table[5, 1].AddParagraph().AppendText(APR.unit_info.team.other.count.ToString());
            }
        }

        private void AddListWithItems(List<string> items)
        {
            IWParagraph listParagraph = GetCurrentSection().AddParagraph();
            for (int i = 0; i < items.Count; i++)
            {
                if (i != items.Count - 1)
                    listParagraph.AppendText(items[i] + "\n");
                else
                    listParagraph.AppendText(items[i]);
            }
            listParagraph.ListFormat.ApplyDefBulletStyle();
        }

        private IWSection AddSectionWithTitle(string title)
        {
            IWSection section = AddSection();
            IWParagraph titleParagraph = AddTitleToSection(section, title);

            return section;
        }

        private IWSection AddSection()
        {
            IWSection section = this.documentReference.AddSection();
            section.BreakCode = SectionBreakCode.NoBreak;
            section.PageSetup.Margins.All = 50f;

            return section;
        }

        private IWParagraph AddTitleToSection(IWSection section, string title)
        {
            IWParagraph title_paragraph = section.AddParagraph();
            title_paragraph.ParagraphFormat.HorizontalAlignment = HorizontalAlignment.Left;

            IWTextRange title_text = title_paragraph.AppendText(title);
            title_text.CharacterFormat.Bold = true;
            title_text.CharacterFormat.FontName = "Times New Roman";
            title_text.CharacterFormat.UnderlineStyle = UnderlineStyle.Single;
            title_text.CharacterFormat.FontSize = 16;
            title_paragraph.AppendText("\n");

            return title_paragraph;
        }

        private void AddTextParagraph(string content)
        {
            IWParagraph paragraph = GetCurrentSection().AddParagraph();
            paragraph.ParagraphFormat.HorizontalAlignment = HorizontalAlignment.Justify;
            paragraph.AppendText(content);
        }

        private IWSection GetCurrentSection()
        {
            return this.documentReference.Sections[this.documentReference.Sections.Count - 1];
        }
    }
}
