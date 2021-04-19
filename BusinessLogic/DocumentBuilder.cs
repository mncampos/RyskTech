// Nuget package SyncFusion
using Syncfusion.DocIO.DLS;
using System;
using System.Collections.Generic;

namespace RyskTech
{
    class DocumentBuilder
    {
        private string documentName;
        private WordDocument documentReference;
        private APR apr;

        public DocumentBuilder(APR apr, string documentName)
        {
            this.apr = apr;
            this.documentName = documentName;

            documentReference = new WordDocument();
            documentReference.EnsureMinimal();
        }

        public int CreateUnitDocumentFromAPR()
        {
            AddUnitInformation();

            documentReference.Save(documentName, Syncfusion.DocIO.FormatType.Docx);
            documentReference.Close();

            return 0;
        }

        public int CreateLabDocumentFromAPR()
        {
            AddLabInformation();

            documentReference.Save(documentName, Syncfusion.DocIO.FormatType.Docx);
            documentReference.Close();

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
            IWSection labSection = AddSectionWithTitle(apr.lab.generalInformation.labName);

            AddLabGeneralInfo(labSection);
            AddLabGeneralDescription(labSection);

            if (apr.lab.generalInformation.manipulatesChemicalAgents)
                AddLabChemicalAgentInfo(labSection);

            // TODO complete when we have this info
        }

        private void AddLabGeneralInfo(IWSection section)
        {
            List<string> items = apr.GetFormattedGeneralInfoList();

            AddSubsectionTitle(section,"a) Informações gerais");
            AddListWithItems(items);
        }

        private void AddLabGeneralDescription(IWSection section)
        {
            AddSubsectionTitle(section, "b) Descrição geral");
            AddTextParagraph(apr.lab.spaceCharacterization.usageCharacterization);
        }

        private void AddLabChemicalAgentInfo(IWSection section)
        {
            if (apr.lab.manipulatedChemicalReactors.Count > 0)
            {
                AddSubsectionTitle(section, "c) Compilação dos reagentes químicos");
                AddChemicalReactorsTable();
            }

            if (apr.lab.manipulatedChemicalResidues.Count > 0)
            {
                AddSubsectionTitle(section, "d) Compilação dos resíduos químicos");
                AddChemicalResidueTable();
            }

            AddChemicalResidueStorageInfo();
            AddSafetyInfo();
        }

        private void AddChemicalReactorsTable()
        {
            IWTable chemicalReactorTable = GetCurrentSection().AddTable();
            chemicalReactorTable.ResetCells(apr.lab.manipulatedChemicalReactors.Count + 1, 10);
            chemicalReactorTable[0, 0].AddParagraph().AppendText(Resources.Language.pt_local.Name);
            chemicalReactorTable[0, 1].AddParagraph().AppendText(Resources.Language.pt_local.PhysicalState);
            chemicalReactorTable[0, 2].AddParagraph().AppendText(Resources.Language.pt_local.Origin);
            chemicalReactorTable[0, 3].AddParagraph().AppendText(Resources.Language.pt_local.Quantity);
            chemicalReactorTable[0, 4].AddParagraph().AppendText(Resources.Language.pt_local.Mixture);
            chemicalReactorTable[0, 5].AddParagraph().AppendText(Resources.Language.pt_local.CasNumber);
            chemicalReactorTable[0, 6].AddParagraph().AppendText(Resources.Language.pt_local.DangerCharacteristics);
            chemicalReactorTable[0, 7].AddParagraph().AppendText(Resources.Language.pt_local.Inert);
            chemicalReactorTable[0, 8].AddParagraph().AppendText(Resources.Language.pt_local.Container);
            chemicalReactorTable[0, 9].AddParagraph().AppendText(Resources.Language.pt_local.StorageInfo);
        
            for (int i = 0; i < apr.lab.manipulatedChemicalReactors.Count; i++)
            {
                chemicalReactorTable[i + 1, 0].AddParagraph().AppendText(apr.lab.manipulatedChemicalReactors[i].name);
                chemicalReactorTable[i + 1, 1].AddParagraph().AppendText(apr.lab.manipulatedChemicalReactors[i].physicalState);
                chemicalReactorTable[i + 1, 2].AddParagraph().AppendText(String.Join("\n", apr.lab.manipulatedChemicalReactors[i].origin));
                chemicalReactorTable[i + 1, 3].AddParagraph().AppendText(apr.lab.manipulatedChemicalReactors[i].quantity + " " + apr.lab.manipulatedChemicalReactors[i].measurementUnit);
                chemicalReactorTable[i + 1, 4].AddParagraph().AppendText(apr.lab.manipulatedChemicalReactors[i].mixtureDescription);
                chemicalReactorTable[i + 1, 5].AddParagraph().AppendText(apr.lab.manipulatedChemicalReactors[i].casNumber);
                chemicalReactorTable[i + 1, 6].AddParagraph().AppendText(String.Join("\n", apr.lab.manipulatedChemicalReactors[i].dangerCharacteristics));
                chemicalReactorTable[i + 1, 7].AddParagraph().AppendText(apr.lab.manipulatedChemicalReactors[i].inert? Resources.Language.pt_local.Yes : Resources.Language.pt_local.No);
                chemicalReactorTable[i + 1, 8].AddParagraph().AppendText(apr.lab.manipulatedChemicalReactors[i].container);
                chemicalReactorTable[i + 1, 9].AddParagraph().AppendText(apr.lab.manipulatedChemicalReactors[i].storageDetails);
            }
        }

        private void AddChemicalResidueTable()
        {
            IWTable chemicalResiduesTable = GetCurrentSection().AddTable();
            chemicalResiduesTable.ResetCells(apr.lab.manipulatedChemicalResidues.Count + 1, 8);
            chemicalResiduesTable[0, 0].AddParagraph().AppendText(Resources.Language.pt_local.Name);
            chemicalResiduesTable[0, 1].AddParagraph().AppendText(Resources.Language.pt_local.PhysicalState);
            chemicalResiduesTable[0, 2].AddParagraph().AppendText(Resources.Language.pt_local.Origin);
            chemicalResiduesTable[0, 3].AddParagraph().AppendText(Resources.Language.pt_local.Quantity);
            chemicalResiduesTable[0, 4].AddParagraph().AppendText(Resources.Language.pt_local.DangerCharacteristics);
            chemicalResiduesTable[0, 5].AddParagraph().AppendText(Resources.Language.pt_local.Inert);
            chemicalResiduesTable[0, 6].AddParagraph().AppendText(Resources.Language.pt_local.Container);
            chemicalResiduesTable[0, 7].AddParagraph().AppendText(Resources.Language.pt_local.StorageInfo);

            for (int i = 0; i < apr.lab.manipulatedChemicalResidues.Count; i++)
            {
                chemicalResiduesTable[i + 1, 0].AddParagraph().AppendText(apr.lab.manipulatedChemicalResidues[i].name);
                chemicalResiduesTable[i + 1, 1].AddParagraph().AppendText(apr.lab.manipulatedChemicalResidues[i].physicalState);
                chemicalResiduesTable[i + 1, 2].AddParagraph().AppendText(String.Join("\n", apr.lab.manipulatedChemicalResidues[i].origin));
                chemicalResiduesTable[i + 1, 3].AddParagraph().AppendText(apr.lab.manipulatedChemicalResidues[i].quantity + " " + apr.lab.manipulatedChemicalResidues[i].measurementUnit);
                chemicalResiduesTable[i + 1, 4].AddParagraph().AppendText(String.Join("\n", apr.lab.manipulatedChemicalResidues[i].dangerCharacteristics));
                chemicalResiduesTable[i + 1, 5].AddParagraph().AppendText(apr.lab.manipulatedChemicalResidues[i].inert ? Resources.Language.pt_local.Yes : Resources.Language.pt_local.No);
                chemicalResiduesTable[i + 1, 6].AddParagraph().AppendText(apr.lab.manipulatedChemicalResidues[i].container);
                chemicalResiduesTable[i + 1, 7].AddParagraph().AppendText(apr.lab.manipulatedChemicalResidues[i].storageDetails);
            }
        }

        private void AddChemicalResidueStorageInfo()
        {
            AddSubsectionTitle(GetCurrentSection(), "e) Informações de armazenamento e disposição");
            
            AddTextParagraph(apr.lab.chemicalResidueStorageInfo.storageDescription);
            AddTextParagraph(apr.lab.chemicalResidueStorageInfo.residueDestination);

            if (!apr.lab.chemicalResidueStorageInfo.NBRCompliant)
                AddTextParagraph("O espaço não apresenta conformidade com a NBR-14725-3:2017");
            else
                AddTextParagraph("O espaço apresenta armazenamento dos seus resíduos de acordo com a NBR-14725-3:2017");

            if (!apr.lab.chemicalResidueStorageInfo.FISPQCompliant)
                AddTextParagraph("O espaço não apresenta FISPQ em conformidade com a NBR-14725-4:2014");
            else
                AddTextParagraph(apr.lab.chemicalResidueStorageInfo.FISPQExplanation);
        }

        private void AddSafetyInfo()
        {
            // TODO
        }

        private void AddUnitTeamInformation()
        {
            List<string> directors = apr.GetDirectorsFormattedDescriptionList();

            AddSectionWithTitle(this.documentReference.Sections.Count + ". Equipe");
            AddTextParagraph("A unidade tem como equipe da direção: ");
            AddListWithItems(directors);
            AddTextParagraph("A composição do pessoal presente na unidade se encontra na tabela abaixo: ");
            AddTeamCompositionTable();
            AddTextParagraph("Para entrar em contato com a unidade, utilizar o telefone " + apr.unit.team.contactPhone);
        }

        private void AddUnitLocationInformation()
        {
            AddSectionWithTitle(this.documentReference.Sections.Count + ". Localização");
            AddTextParagraph("A unidade está localizada em " + apr.GetLocationString() + "." + apr.unit.structure.surroundingsDetails);
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
            AddTextParagraph(apr.unit.history);
        }

        private void AddAPRMethodologyInformation()
        {
            AddSectionWithTitle(this.documentReference.Sections.Count + ". Metodologia");
            AddTextParagraph(apr.unit.methodologyDescription);
        }

        private void AddRoomsBuildingsTimesTable()
        {
            // Create table with rooms, buildings and time ranges
            IWTable unit_spaces_table = GetCurrentSection().AddTable();
            unit_spaces_table.ResetCells(apr.unit.structure.spaces.Count + 1, 4);
            unit_spaces_table[0, 0].AddParagraph().AppendText(Resources.Language.pt_local.Building);
            unit_spaces_table[0, 1].AddParagraph().AppendText(Resources.Language.pt_local.Room);
            unit_spaces_table[0, 2].AddParagraph().AppendText(Resources.Language.pt_local.Floor);
            unit_spaces_table[0, 3].AddParagraph().AppendText(Resources.Language.pt_local.UsagePeriod);
            for (int i = 0; i < apr.unit.structure.spaces.Count; i++)
            {
                unit_spaces_table[i + 1, 0].AddParagraph().AppendText(apr.unit.structure.spaces[i].buildingIdentifier);
                unit_spaces_table[i + 1, 1].AddParagraph().AppendText(apr.unit.structure.spaces[i].roomIdentifier);
                unit_spaces_table[i + 1, 2].AddParagraph().AppendText(apr.unit.structure.spaces[i].floorIdentifier);
                unit_spaces_table[i + 1, 3].AddParagraph().AppendText(apr.unit.structure.spaces[i].turnStart.ToString() + " - " + apr.unit.structure.spaces[i].turnEnd.ToString()); // TODO Parse times
            }
        }

        private void AddTeamCompositionTable()
        {
            IWTable unit_team_table = GetCurrentSection().AddTable();
            unit_team_table.ResetCells(6, 2);
            unit_team_table[0, 0].AddParagraph().AppendText(Resources.Language.pt_local.Type);
            unit_team_table[0, 1].AddParagraph().AppendText(Resources.Language.pt_local.Quantity);

            // Public
            unit_team_table[1, 0].AddParagraph().AppendText(Resources.Language.pt_local.Public);
            unit_team_table[1, 1].AddParagraph().AppendText(apr.unit.team.generalPublicCount.ToString());

            // Students
            unit_team_table[2, 0].AddParagraph().AppendText(Resources.Language.pt_local.Students);
            unit_team_table[2, 1].AddParagraph().AppendText(apr.unit.team.studentsCount.ToString());

            // Teachers
            unit_team_table[3, 0].AddParagraph().AppendText(Resources.Language.pt_local.Teachers);
            unit_team_table[3, 1].AddParagraph().AppendText(apr.unit.team.teachersCount.ToString());

            // Technics
            unit_team_table[4, 0].AddParagraph().AppendText(Resources.Language.pt_local.Technics);
            unit_team_table[4, 1].AddParagraph().AppendText(apr.unit.team.technicsCount.ToString());

            // Other
            if (apr.unit.team.otherDescription != null)
            {
                unit_team_table[5, 0].AddParagraph().AppendText(apr.unit.team.otherDescription);
                unit_team_table[5, 1].AddParagraph().AppendText(apr.unit.team.otherCount.ToString());
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

        private void AddSubsectionTitle(IWSection section, string subsectionTile)
        {
            IWParagraph title_paragraph = section.AddParagraph();
            IWTextRange title_text = title_paragraph.AppendText(subsectionTile);
            title_text.CharacterFormat.Bold = false;
            title_text.CharacterFormat.FontName = "Times New Roman";
            title_text.CharacterFormat.UnderlineStyle = UnderlineStyle.Single;
            title_text.CharacterFormat.FontSize = 14;
            title_paragraph.AppendText("\n");
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
