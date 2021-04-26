using RyskTech.Forms.Unit.Controls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace RyskTech.Forms.Unit
{
    public partial class UnitMainFormBetter : Form
    {
        private Data.Unit data;
        private int progress;

        private TestWelcomeControl testWelcomeControl;
        private TestLocationControl testLocationControl;
        private TestTeamControl testTeamControl;
        private TestStructureControl testStructureControl;
        private TestHistoryControl testHistoryControl;
        private TestMethodologyControl testMethodologyControl;

        public UnitMainFormBetter()
        {
            InitializeComponent();
        }

        private void UITestForm_Load(object sender, EventArgs e)
        {
            testWelcomeControl = new TestWelcomeControl();
            testWelcomeControl.Dock = DockStyle.Fill;

            testLocationControl = new TestLocationControl();
            testLocationControl.Dock = DockStyle.Fill;

            testTeamControl = new TestTeamControl();
            testTeamControl.Dock = DockStyle.Fill;

            testStructureControl = new TestStructureControl();
            testStructureControl.Dock = DockStyle.Fill;

            testHistoryControl = new TestHistoryControl();
            testHistoryControl.Dock = DockStyle.Fill;

            testMethodologyControl = new TestMethodologyControl();
            testMethodologyControl.Dock = DockStyle.Fill;

            activeControlPanel.Controls.Add(testWelcomeControl);
            welcomeTabButton.BackColor = Color.DarkGray;

            progress = 1;
            this.data = new Data.Unit();
        }

        private void cleartabButtonColors()
        {
            welcomeTabButton.BackColor = Color.LightGray;
            locationTabButton.BackColor = Color.LightGray;
            teamTabButton.BackColor = Color.LightGray;
            structureTabButton.BackColor = Color.LightGray;
            historyTabButton.BackColor = Color.LightGray;
            methodologyTabButton.BackColor = Color.LightGray;
        }

        private void welcomeTabButton_Click(object sender, EventArgs e)
        {
            activeControlPanel.Controls.Clear();
            activeControlPanel.Controls.Add(testWelcomeControl);

            cleartabButtonColors();
            welcomeTabButton.BackColor = Color.DarkGray;
            activePanelLabel.Text = "Bem Vindo!";
            nextConcludeButton.Text = "Próximo";

            progress = 1;
        }

        private void locationTabButton_Click(object sender, EventArgs e)
        {
            activeControlPanel.Controls.Clear();
            activeControlPanel.Controls.Add(testLocationControl);

            cleartabButtonColors();
            locationTabButton.BackColor = Color.DarkGray;
            activePanelLabel.Text = "Localização";
            nextConcludeButton.Text = "Próximo";

            progress = 2;
        }

        private void teamTabButton_Click(object sender, EventArgs e)
        {
            activeControlPanel.Controls.Clear();
            activeControlPanel.Controls.Add(testTeamControl);

            cleartabButtonColors();
            teamTabButton.BackColor = Color.DarkGray;
            activePanelLabel.Text = "Equipe";
            nextConcludeButton.Text = "Próximo";

            progress = 3;
        }

        private void structureTabButton_Click(object sender, EventArgs e)
        {
            activeControlPanel.Controls.Clear();
            activeControlPanel.Controls.Add(testStructureControl);

            cleartabButtonColors();
            structureTabButton.BackColor = Color.DarkGray;
            activePanelLabel.Text = "Estrutura";
            nextConcludeButton.Text = "Próximo";

            progress = 4;
        }

        private void historyTabButton_Click(object sender, EventArgs e)
        {
            activeControlPanel.Controls.Clear();
            activeControlPanel.Controls.Add(testHistoryControl);

            cleartabButtonColors();
            historyTabButton.BackColor = Color.DarkGray;
            activePanelLabel.Text = "Histórico";
            nextConcludeButton.Text = "Próximo";

            progress = 5;
        }

        private void methodologyTabButton_Click(object sender, EventArgs e)
        {
            activeControlPanel.Controls.Clear();
            activeControlPanel.Controls.Add(testMethodologyControl);

            cleartabButtonColors();
            methodologyTabButton.BackColor = Color.DarkGray;
            activePanelLabel.Text = "Metodologia";
            nextConcludeButton.Text = "Concluir";

            progress = 6;
        }

        private void PrepareForGeneration()
        {
            testWelcomeControl.ValidateData();
            data.generalInformation = testWelcomeControl.data;

            testLocationControl.ValidateData();
            data.location = testLocationControl.data;

            testTeamControl.ValidateData();
            data.team = testTeamControl.data;

            testStructureControl.ValidateData();
            data.structure = testStructureControl.data;

            testHistoryControl.ValidateData();
            data.history = testHistoryControl.history;

            testMethodologyControl.ValidateData();
            data.methodologyDescription = testMethodologyControl.methodology;
        }

        private void conclude()
        {
            try
            {
                PrepareForGeneration();

                APR compilation = new APR(data);
                DocumentBuilder docBuilder = new DocumentBuilder(compilation, "APR_Unidade.docx");

                int statusCode = docBuilder.CreateUnitDocumentFromAPR();

                if (statusCode == 0)
                    MessageBox.Show("APR Gerada com sucesso!", "Obrigado por usar RyskTech! :)");
                else
                    MessageBox.Show("Foram encontrados alguns erros na geração da APR", ":(");

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void nextConcludeButton_Click(object sender, EventArgs e)
        {
            switch (progress)
            {
                case 1:
                    locationTabButton_Click(this, null);
                    break;
                case 2:
                    teamTabButton_Click(this, null);
                    break;
                case 3:
                    structureTabButton_Click(this, null);
                    break;
                case 4:
                    historyTabButton_Click(this, null);
                    break;
                case 5:
                    methodologyTabButton_Click(this, null);
                    break;
                case 6:
                    conclude();
                    break;
            }

        }
    }
}
